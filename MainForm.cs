using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniKey
{
    public partial class MainForm : Form
    {
        private readonly Random _rng = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Вспомогательные методы

        private int CountLines(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;
            return text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None)
                       .Count(line => line.Length > 0);
        }

        private string[] GetNonEmptyLines(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new string[0];
            return text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None)
                       .Where(line => line.Length > 0)
                       .ToArray();
        }

        private void SetResult(IEnumerable<string> lines)
        {
            txtResult.Text = string.Join(Environment.NewLine, lines);
        }

        /// <summary>
        /// Считает количество слов в строке (по пробелам).
        /// </summary>
        private int CountWords(string line)
        {
            if (string.IsNullOrEmpty(line))
                return 0;
            return line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        #endregion

        #region Обновление счётчиков

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            lblInput.Text = "Входящие данные: " + CountLines(txtInput.Text);
        }

        private void TxtInclusions_TextChanged(object sender, EventArgs e)
        {
            lblInclusions.Text = "Обязательные включения: " + CountLines(txtInclusions.Text);
        }

        private void TxtExclusions_TextChanged(object sender, EventArgs e)
        {
            lblExclusions.Text = "Обязательные исключения: " + CountLines(txtExclusions.Text);
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Результат: " + CountLines(txtResult.Text);
        }

        #endregion

        #region Основные кнопки

        /// <summary>
        /// Сделать выборку — фильтрация входящих данных
        /// по обязательным включениям и исключениям.
        /// </summary>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            var inputLines = GetNonEmptyLines(txtInput.Text);
            var inclusions = GetNonEmptyLines(txtInclusions.Text);
            var exclusions = GetNonEmptyLines(txtExclusions.Text);

            bool fullInc = chkFullInclusion.Checked;
            bool fullExc = chkFullExclusion.Checked;

            var result = new List<string>();

            foreach (var line in inputLines)
            {
                bool passInclusion = true;
                if (inclusions.Length > 0)
                {
                    if (fullInc)
                        passInclusion = inclusions.Any(inc =>
                            string.Equals(line, inc, StringComparison.Ordinal));
                    else
                        passInclusion = inclusions.Any(inc =>
                            line.IndexOf(inc, StringComparison.Ordinal) >= 0);
                }

                bool passExclusion = true;
                if (exclusions.Length > 0)
                {
                    if (fullExc)
                        passExclusion = !exclusions.Any(exc =>
                            string.Equals(line, exc, StringComparison.Ordinal));
                    else
                        passExclusion = !exclusions.Any(exc =>
                            line.IndexOf(exc, StringComparison.Ordinal) >= 0);
                }

                if (passInclusion && passExclusion)
                    result.Add(line);
            }

            SetResult(result);
            lblStatus.Text = "Готово.";
        }

        /// <summary>
        /// Сортировка А-Я — из Входящих данных, по алфавиту → Результат.
        /// </summary>
        private void BtnSortAZ_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            var lines = GetNonEmptyLines(txtInput.Text);
            Array.Sort(lines, StringComparer.CurrentCulture);
            SetResult(lines);
            lblStatus.Text = "Готово.";
        }

        /// <summary>
        /// Сортировка Я-А — из Входящих данных, обратный алфавит → Результат.
        /// </summary>
        private void BtnSortZA_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            var lines = GetNonEmptyLines(txtInput.Text);
            Array.Sort(lines, StringComparer.CurrentCulture);
            Array.Reverse(lines);
            SetResult(lines);
            lblStatus.Text = "Готово.";
        }

        /// <summary>
        /// Перемешать — из Входящих данных, рандомно → Результат.
        /// </summary>
        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            var lines = GetNonEmptyLines(txtInput.Text);
            for (int i = lines.Length - 1; i > 0; i--)
            {
                int j = _rng.Next(i + 1);
                string tmp = lines[i];
                lines[i] = lines[j];
                lines[j] = tmp;
            }
            SetResult(lines);
            lblStatus.Text = "Готово.";
        }

        /// <summary>
        /// Удалить дубли — из Входящих данных, уникальные → Результат.
        /// </summary>
        private void BtnRemoveDuplicates_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            var lines = GetNonEmptyLines(txtInput.Text);
            var seen = new HashSet<string>(StringComparer.Ordinal);
            var unique = new List<string>();

            foreach (var line in lines)
            {
                if (seen.Add(line))
                    unique.Add(line);
            }

            SetResult(unique);
            lblStatus.Text = "Готово.";
        }

        /// <summary>
        /// Разбить на файлы — из Входящих данных, построчно в папку split/.
        /// </summary>
        private void BtnSplit_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            int linesPerFile;
            if (!int.TryParse(txtSplitCount.Text.Trim(), out linesPerFile) || linesPerFile <= 0)
            {
                MessageBox.Show(
                    "Укажите корректное положительное число строк для разбивки.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lines = GetNonEmptyLines(txtInput.Text);
            if (lines.Length == 0)
            {
                MessageBox.Show(
                    "Входящие данные пусты — нечего разбивать.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string exeDir = AppDomain.CurrentDomain.BaseDirectory;
            string splitDir = Path.Combine(exeDir, "split");
            Directory.CreateDirectory(splitDir);

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            int fileCount = 0;

            for (int i = 0; i < lines.Length; i += linesPerFile)
            {
                fileCount++;
                var chunk = lines.Skip(i).Take(linesPerFile).ToArray();
                string fileName = string.Format("{0}_{1}.txt", timestamp, fileCount);
                string filePath = Path.Combine(splitDir, fileName);
                File.WriteAllLines(filePath, chunk, Encoding.UTF8);
            }

            lblStatus.Text = "Готово.";
            MessageBox.Show(
                string.Format("Сохранено {0} файл(ов) в папку:\n{1}", fileCount, splitDir),
                "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Фильтры по символам

        /// <summary>
        /// Символов в строке не более X — из Входящих данных оставляет
        /// только строки, длина которых <= указанного числа символов.
        /// </summary>
        private void BtnFilterMaxChars_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            int maxChars;
            if (!int.TryParse(txtMaxChars.Text.Trim(), out maxChars) || maxChars < 0)
            {
                MessageBox.Show(
                    "Укажите корректное неотрицательное число символов.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lines = GetNonEmptyLines(txtInput.Text);
            var result = lines.Where(line => line.Length <= maxChars).ToArray();
            SetResult(result);
            lblStatus.Text = "Готово.";
        }

        /// <summary>
        /// Символов в строке более X — из Входящих данных оставляет
        /// только строки, длина которых > указанного числа символов.
        /// </summary>
        private void BtnFilterMinChars_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            int minChars;
            if (!int.TryParse(txtMinChars.Text.Trim(), out minChars) || minChars < 0)
            {
                MessageBox.Show(
                    "Укажите корректное неотрицательное число символов.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lines = GetNonEmptyLines(txtInput.Text);
            var result = lines.Where(line => line.Length > minChars).ToArray();
            SetResult(result);
            lblStatus.Text = "Готово.";
        }

        #endregion

        #region Фильтры по словам

        /// <summary>
        /// Слов в строке не более X — из Входящих данных оставляет
        /// только строки, в которых кол-во слов <= X (считаем по пробелам).
        /// </summary>
        private void BtnFilterMaxWords_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            int maxWords;
            if (!int.TryParse(txtMaxWords.Text.Trim(), out maxWords) || maxWords < 0)
            {
                MessageBox.Show(
                    "Укажите корректное неотрицательное число слов.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lines = GetNonEmptyLines(txtInput.Text);
            var result = lines.Where(line => CountWords(line) <= maxWords).ToArray();
            SetResult(result);
            lblStatus.Text = "Готово.";
        }

        /// <summary>
        /// Слов в строке более X — из Входящих данных оставляет
        /// только строки, в которых кол-во слов > X (считаем по пробелам).
        /// </summary>
        private void BtnFilterMinWords_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            int minWords;
            if (!int.TryParse(txtMinWords.Text.Trim(), out minWords) || minWords < 0)
            {
                MessageBox.Show(
                    "Укажите корректное неотрицательное число слов.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lines = GetNonEmptyLines(txtInput.Text);
            var result = lines.Where(line => CountWords(line) > minWords).ToArray();
            SetResult(result);
            lblStatus.Text = "Готово.";
        }

        #endregion

        #region Ссылка

        private void LnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://vladimir-awm.ru/unikej-besplatnaya-programma-dlya-obrabotki-klyuchevyx-slov/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось открыть ссылку: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
