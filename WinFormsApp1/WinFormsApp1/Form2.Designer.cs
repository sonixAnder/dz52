namespace WinFormsApp1
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowse = new Button();
            btnSearch = new Button();
            lstFiles = new ListBox();
            txtFolderPath = new TextBox();
            txtSearchPattern = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(12, 30);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Обзор";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 101);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Искать";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 15;
            lstFiles.Location = new Point(329, 30);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(459, 94);
            lstFiles.TabIndex = 2;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(93, 30);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(230, 23);
            txtFolderPath.TabIndex = 3;
            // 
            // txtSearchPattern
            // 
            txtSearchPattern.Location = new Point(93, 102);
            txtSearchPattern.Name = "txtSearchPattern";
            txtSearchPattern.Size = new Size(230, 23);
            txtSearchPattern.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 5;
            label1.Text = "Путь к папке";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 69);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 6;
            label2.Text = "Какой файл нужно искать\r\n(если не указать, будет искать все)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 9);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Результат";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 135);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchPattern);
            Controls.Add(txtFolderPath);
            Controls.Add(lstFiles);
            Controls.Add(btnSearch);
            Controls.Add(btnBrowse);
            Name = "SearchForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск файлов";
            Load += SearchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Button btnSearch;
        private ListBox lstFiles;
        private TextBox txtFolderPath;
        private TextBox txtSearchPattern;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}