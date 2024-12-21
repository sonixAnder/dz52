namespace sale_of_computer_components
{
    partial class FormSales
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
            comboBoxProducts = new ComboBox();
            textBoxPrice = new TextBox();
            buttonAdd = new Button();
            listBoxSales = new ListBox();
            labelTotalCost = new Label();
            buttonManageProducts = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(5, 24);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(370, 23);
            comboBoxProducts.TabIndex = 0;
            comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(379, 24);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(379, 53);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxSales
            // 
            listBoxSales.FormattingEnabled = true;
            listBoxSales.ItemHeight = 15;
            listBoxSales.Location = new Point(5, 68);
            listBoxSales.Name = "listBoxSales";
            listBoxSales.Size = new Size(370, 94);
            listBoxSales.TabIndex = 3;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Location = new Point(460, 61);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(107, 15);
            labelTotalCost.TabIndex = 4;
            labelTotalCost.Text = "Общая стоимость";
            // 
            // buttonManageProducts
            // 
            buttonManageProducts.Location = new Point(379, 82);
            buttonManageProducts.Name = "buttonManageProducts";
            buttonManageProducts.Size = new Size(137, 23);
            buttonManageProducts.TabIndex = 5;
            buttonManageProducts.Text = "Управление товарами";
            buttonManageProducts.UseVisualStyleBackColor = true;
            buttonManageProducts.Click += buttonManageProducts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "Цена";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 6);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 7;
            label2.Text = "Список комплектующих";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 50);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "Список";
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 190);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonManageProducts);
            Controls.Add(labelTotalCost);
            Controls.Add(listBoxSales);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrice);
            Controls.Add(comboBoxProducts);
            Name = "FormSales";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProducts;
        private TextBox textBoxPrice;
        private Button buttonAdd;
        private ListBox listBoxSales;
        private Label labelTotalCost;
        private Button buttonManageProducts;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}