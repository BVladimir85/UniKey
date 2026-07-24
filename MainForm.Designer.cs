namespace UniKey
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInclusions = new System.Windows.Forms.Label();
            this.chkFullInclusion = new System.Windows.Forms.CheckBox();
            this.txtInclusions = new System.Windows.Forms.TextBox();
            this.lblExclusions = new System.Windows.Forms.Label();
            this.chkFullExclusion = new System.Windows.Forms.CheckBox();
            this.txtExclusions = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnRemoveDuplicates = new System.Windows.Forms.Button();
            this.txtSplitCount = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            // Фильтры по символам
            this.lblMaxChars = new System.Windows.Forms.Label();
            this.txtMaxChars = new System.Windows.Forms.TextBox();
            this.btnFilterMaxChars = new System.Windows.Forms.Button();
            this.lblMinChars = new System.Windows.Forms.Label();
            this.txtMinChars = new System.Windows.Forms.TextBox();
            this.btnFilterMinChars = new System.Windows.Forms.Button();
            // Фильтры по словам
            this.lblMaxWords = new System.Windows.Forms.Label();
            this.txtMaxWords = new System.Windows.Forms.TextBox();
            this.btnFilterMaxWords = new System.Windows.Forms.Button();
            this.lblMinWords = new System.Windows.Forms.Label();
            this.txtMinWords = new System.Windows.Forms.TextBox();
            this.btnFilterMinWords = new System.Windows.Forms.Button();
            this.lnkWebsite = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblInput
            //
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 12);
            this.lblInput.Name = "lblInput";
            this.lblInput.Text = "Входящие данные: 0";
            //
            // txtInput
            //
            this.txtInput.Location = new System.Drawing.Point(12, 32);
            this.txtInput.MaxLength = 0;
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(285, 458);
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            //
            // lblInclusions
            //
            this.lblInclusions.AutoSize = true;
            this.lblInclusions.Location = new System.Drawing.Point(312, 12);
            this.lblInclusions.Name = "lblInclusions";
            this.lblInclusions.Text = "Обязательные включения: 0";
            //
            // chkFullInclusion
            //
            this.chkFullInclusion.AutoSize = true;
            this.chkFullInclusion.Location = new System.Drawing.Point(315, 32);
            this.chkFullInclusion.Name = "chkFullInclusion";
            this.chkFullInclusion.Size = new System.Drawing.Size(170, 17);
            this.chkFullInclusion.Text = "Полное включение строки";
            this.chkFullInclusion.UseVisualStyleBackColor = true;
            //
            // txtInclusions
            //
            this.txtInclusions.Location = new System.Drawing.Point(312, 55);
            this.txtInclusions.MaxLength = 0;
            this.txtInclusions.Multiline = true;
            this.txtInclusions.Name = "txtInclusions";
            this.txtInclusions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInclusions.Size = new System.Drawing.Size(258, 185);
            this.txtInclusions.TextChanged += new System.EventHandler(this.TxtInclusions_TextChanged);
            //
            // lblExclusions
            //
            this.lblExclusions.AutoSize = true;
            this.lblExclusions.Location = new System.Drawing.Point(312, 248);
            this.lblExclusions.Name = "lblExclusions";
            this.lblExclusions.Text = "Обязательные исключения: 0";
            //
            // chkFullExclusion
            //
            this.chkFullExclusion.AutoSize = true;
            this.chkFullExclusion.Location = new System.Drawing.Point(315, 268);
            this.chkFullExclusion.Name = "chkFullExclusion";
            this.chkFullExclusion.Size = new System.Drawing.Size(170, 17);
            this.chkFullExclusion.Text = "Полное исключение строки";
            this.chkFullExclusion.UseVisualStyleBackColor = true;
            //
            // txtExclusions
            //
            this.txtExclusions.Location = new System.Drawing.Point(312, 291);
            this.txtExclusions.MaxLength = 0;
            this.txtExclusions.Multiline = true;
            this.txtExclusions.Name = "txtExclusions";
            this.txtExclusions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExclusions.Size = new System.Drawing.Size(258, 199);
            this.txtExclusions.TextChanged += new System.EventHandler(this.TxtExclusions_TextChanged);
            //
            // lblResult
            //
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(585, 12);
            this.lblResult.Name = "lblResult";
            this.lblResult.Text = "Результат: 0";
            //
            // txtResult
            //
            this.txtResult.Location = new System.Drawing.Point(585, 32);
            this.txtResult.MaxLength = 0;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(325, 458);
            this.txtResult.TextChanged += new System.EventHandler(this.TxtResult_TextChanged);
            //
            // btnSelect
            //
            this.btnSelect.Location = new System.Drawing.Point(12, 502);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(120, 30);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Сделать выборку";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            //
            // btnSortAZ
            //
            this.btnSortAZ.Location = new System.Drawing.Point(140, 502);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(118, 30);
            this.btnSortAZ.TabIndex = 11;
            this.btnSortAZ.Text = "Сортировка А-Я";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.BtnSortAZ_Click);
            //
            // btnSortZA
            //
            this.btnSortZA.Location = new System.Drawing.Point(266, 502);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(118, 30);
            this.btnSortZA.TabIndex = 12;
            this.btnSortZA.Text = "Сортировка Я-А";
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.BtnSortZA_Click);
            //
            // btnShuffle
            //
            this.btnShuffle.Location = new System.Drawing.Point(392, 502);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(105, 30);
            this.btnShuffle.TabIndex = 13;
            this.btnShuffle.Text = "Перемешать";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            //
            // btnRemoveDuplicates
            //
            this.btnRemoveDuplicates.Location = new System.Drawing.Point(548, 502);
            this.btnRemoveDuplicates.Name = "btnRemoveDuplicates";
            this.btnRemoveDuplicates.Size = new System.Drawing.Size(115, 30);
            this.btnRemoveDuplicates.TabIndex = 14;
            this.btnRemoveDuplicates.Text = "Удалить дубли";
            this.btnRemoveDuplicates.UseVisualStyleBackColor = true;
            this.btnRemoveDuplicates.Click += new System.EventHandler(this.BtnRemoveDuplicates_Click);
            //
            // txtSplitCount
            //
            this.txtSplitCount.Location = new System.Drawing.Point(672, 506);
            this.txtSplitCount.Name = "txtSplitCount";
            this.txtSplitCount.Size = new System.Drawing.Size(50, 20);
            this.txtSplitCount.TabIndex = 15;
            this.txtSplitCount.Text = "10";
            this.txtSplitCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnSplit
            //
            this.btnSplit.Location = new System.Drawing.Point(730, 502);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(130, 30);
            this.btnSplit.TabIndex = 16;
            this.btnSplit.Text = "Разбить на файлы";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // ===================================================
            // Фильтр: Символов в строке не более
            // ===================================================
            //
            // lblMaxChars
            //
            this.lblMaxChars.AutoSize = true;
            this.lblMaxChars.Location = new System.Drawing.Point(12, 542);
            this.lblMaxChars.Name = "lblMaxChars";
            this.lblMaxChars.Text = "Символов в строке не более:";
            //
            // txtMaxChars
            //
            this.txtMaxChars.Location = new System.Drawing.Point(12, 560);
            this.txtMaxChars.Name = "txtMaxChars";
            this.txtMaxChars.Size = new System.Drawing.Size(50, 20);
            this.txtMaxChars.TabIndex = 20;
            this.txtMaxChars.Text = "140";
            this.txtMaxChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnFilterMaxChars
            //
            this.btnFilterMaxChars.Location = new System.Drawing.Point(68, 557);
            this.btnFilterMaxChars.Name = "btnFilterMaxChars";
            this.btnFilterMaxChars.Size = new System.Drawing.Size(100, 26);
            this.btnFilterMaxChars.TabIndex = 21;
            this.btnFilterMaxChars.Text = "Отфильтровать";
            this.btnFilterMaxChars.UseVisualStyleBackColor = true;
            this.btnFilterMaxChars.Click += new System.EventHandler(this.BtnFilterMaxChars_Click);
            // ===================================================
            // Фильтр: Символов в строке более
            // ===================================================
            //
            // lblMinChars
            //
            this.lblMinChars.AutoSize = true;
            this.lblMinChars.Location = new System.Drawing.Point(230, 542);
            this.lblMinChars.Name = "lblMinChars";
            this.lblMinChars.Text = "Символов в строке более:";
            //
            // txtMinChars
            //
            this.txtMinChars.Location = new System.Drawing.Point(230, 560);
            this.txtMinChars.Name = "txtMinChars";
            this.txtMinChars.Size = new System.Drawing.Size(50, 20);
            this.txtMinChars.TabIndex = 22;
            this.txtMinChars.Text = "140";
            this.txtMinChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnFilterMinChars
            //
            this.btnFilterMinChars.Location = new System.Drawing.Point(286, 557);
            this.btnFilterMinChars.Name = "btnFilterMinChars";
            this.btnFilterMinChars.Size = new System.Drawing.Size(100, 26);
            this.btnFilterMinChars.TabIndex = 23;
            this.btnFilterMinChars.Text = "Отфильтровать";
            this.btnFilterMinChars.UseVisualStyleBackColor = true;
            this.btnFilterMinChars.Click += new System.EventHandler(this.BtnFilterMinChars_Click);
            // ===================================================
            // Фильтр: Слов в строке не более
            // ===================================================
            //
            // lblMaxWords
            //
            this.lblMaxWords.AutoSize = true;
            this.lblMaxWords.Location = new System.Drawing.Point(458, 542);
            this.lblMaxWords.Name = "lblMaxWords";
            this.lblMaxWords.Text = "Слов в строке не более:";
            //
            // txtMaxWords
            //
            this.txtMaxWords.Location = new System.Drawing.Point(458, 560);
            this.txtMaxWords.Name = "txtMaxWords";
            this.txtMaxWords.Size = new System.Drawing.Size(50, 20);
            this.txtMaxWords.TabIndex = 24;
            this.txtMaxWords.Text = "5";
            this.txtMaxWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnFilterMaxWords
            //
            this.btnFilterMaxWords.Location = new System.Drawing.Point(514, 557);
            this.btnFilterMaxWords.Name = "btnFilterMaxWords";
            this.btnFilterMaxWords.Size = new System.Drawing.Size(100, 26);
            this.btnFilterMaxWords.TabIndex = 25;
            this.btnFilterMaxWords.Text = "Отфильтровать";
            this.btnFilterMaxWords.UseVisualStyleBackColor = true;
            this.btnFilterMaxWords.Click += new System.EventHandler(this.BtnFilterMaxWords_Click);
            // ===================================================
            // Фильтр: Слов в строке более
            // ===================================================
            //
            // lblMinWords
            //
            this.lblMinWords.AutoSize = true;
            this.lblMinWords.Location = new System.Drawing.Point(680, 542);
            this.lblMinWords.Name = "lblMinWords";
            this.lblMinWords.Text = "Слов в строке более:";
            //
            // txtMinWords
            //
            this.txtMinWords.Location = new System.Drawing.Point(680, 560);
            this.txtMinWords.Name = "txtMinWords";
            this.txtMinWords.Size = new System.Drawing.Size(50, 20);
            this.txtMinWords.TabIndex = 26;
            this.txtMinWords.Text = "5";
            this.txtMinWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnFilterMinWords
            //
            this.btnFilterMinWords.Location = new System.Drawing.Point(736, 557);
            this.btnFilterMinWords.Name = "btnFilterMinWords";
            this.btnFilterMinWords.Size = new System.Drawing.Size(100, 26);
            this.btnFilterMinWords.TabIndex = 27;
            this.btnFilterMinWords.Text = "Отфильтровать";
            this.btnFilterMinWords.UseVisualStyleBackColor = true;
            this.btnFilterMinWords.Click += new System.EventHandler(this.BtnFilterMinWords_Click);
            // ===================================================
            // Ссылка и статус
            // ===================================================
            //
            // lnkWebsite
            //
            this.lnkWebsite.AutoSize = true;
            this.lnkWebsite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkWebsite.Location = new System.Drawing.Point(810, 602);
            this.lnkWebsite.Name = "lnkWebsite";
            this.lnkWebsite.Size = new System.Drawing.Size(100, 15);
            this.lnkWebsite.TabIndex = 30;
            this.lnkWebsite.TabStop = true;
            this.lnkWebsite.Text = "Сайт программы";
            this.lnkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkWebsite_LinkClicked);
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(12, 602);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.Text = "";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 642);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInclusions);
            this.Controls.Add(this.chkFullInclusion);
            this.Controls.Add(this.txtInclusions);
            this.Controls.Add(this.lblExclusions);
            this.Controls.Add(this.chkFullExclusion);
            this.Controls.Add(this.txtExclusions);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSortAZ);
            this.Controls.Add(this.btnSortZA);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnRemoveDuplicates);
            this.Controls.Add(this.txtSplitCount);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lblMaxChars);
            this.Controls.Add(this.txtMaxChars);
            this.Controls.Add(this.btnFilterMaxChars);
            this.Controls.Add(this.lblMinChars);
            this.Controls.Add(this.txtMinChars);
            this.Controls.Add(this.btnFilterMinChars);
            this.Controls.Add(this.lblMaxWords);
            this.Controls.Add(this.txtMaxWords);
            this.Controls.Add(this.btnFilterMaxWords);
            this.Controls.Add(this.lblMinWords);
            this.Controls.Add(this.txtMinWords);
            this.Controls.Add(this.btnFilterMinWords);
            this.Controls.Add(this.lnkWebsite);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УниКей (@Vladimir-AWM)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInclusions;
        private System.Windows.Forms.CheckBox chkFullInclusion;
        private System.Windows.Forms.TextBox txtInclusions;
        private System.Windows.Forms.Label lblExclusions;
        private System.Windows.Forms.CheckBox chkFullExclusion;
        private System.Windows.Forms.TextBox txtExclusions;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnRemoveDuplicates;
        private System.Windows.Forms.TextBox txtSplitCount;
        private System.Windows.Forms.Button btnSplit;
        // Фильтры по символам
        private System.Windows.Forms.Label lblMaxChars;
        private System.Windows.Forms.TextBox txtMaxChars;
        private System.Windows.Forms.Button btnFilterMaxChars;
        private System.Windows.Forms.Label lblMinChars;
        private System.Windows.Forms.TextBox txtMinChars;
        private System.Windows.Forms.Button btnFilterMinChars;
        // Фильтры по словам
        private System.Windows.Forms.Label lblMaxWords;
        private System.Windows.Forms.TextBox txtMaxWords;
        private System.Windows.Forms.Button btnFilterMaxWords;
        private System.Windows.Forms.Label lblMinWords;
        private System.Windows.Forms.TextBox txtMinWords;
        private System.Windows.Forms.Button btnFilterMinWords;

        private System.Windows.Forms.LinkLabel lnkWebsite;
        private System.Windows.Forms.Label lblStatus;
    }
}
