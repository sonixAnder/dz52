namespace sale_of_computer_components
{
    partial class FormManageProducts
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
            textBoxName = new TextBox();
            textBoxFeatures = new TextBox();
            textBoxDescription = new TextBox();
            textBoxPrice = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            listBoxProducts = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 28);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(177, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxFeatures
            // 
            textBoxFeatures.Location = new Point(195, 28);
            textBoxFeatures.Multiline = true;
            textBoxFeatures.Name = "textBoxFeatures";
            textBoxFeatures.Size = new Size(177, 123);
            textBoxFeatures.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(378, 28);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(177, 23);
            textBoxDescription.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(561, 28);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(177, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 57);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(12, 86);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 23);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(378, 71);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(360, 94);
            listBoxProducts.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 10);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 8;
            label2.Text = "Характеристики";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 10);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 9;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 9);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 10;
            label4.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 54);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 11;
            label5.Text = "Список комплектующих";
            // 
            // FormManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 185);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxFeatures);
            Controls.Add(textBoxName);
            Name = "FormManageProducts";
            Text = "FormManageProducts";
            Load += FormManageProducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxFeatures;
        private TextBox textBoxDescription;
        private TextBox textBoxPrice;
        private Button buttonAdd;
        private Button buttonEdit;
        private ListBox listBoxProducts;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}