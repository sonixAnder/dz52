namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenSearchForm = new Button();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnOpenSearchForm
            // 
            btnOpenSearchForm.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenSearchForm.Location = new Point(31, 58);
            btnOpenSearchForm.Name = "btnOpenSearchForm";
            btnOpenSearchForm.Size = new Size(68, 48);
            btnOpenSearchForm.TabIndex = 0;
            btnOpenSearchForm.Text = "ДА";
            btnOpenSearchForm.UseVisualStyleBackColor = true;
            btnOpenSearchForm.Click += btnOpenSearchForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 1;
            label1.Text = "Начать поиск?";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(155, 58);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(72, 48);
            btnClose.TabIndex = 2;
            btnClose.Text = "НЕТ";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 128);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(btnOpenSearchForm);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начало";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenSearchForm;
        private Label label1;
        private Button btnClose;
    }
}