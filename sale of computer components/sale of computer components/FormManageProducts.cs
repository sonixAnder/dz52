using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sale_of_computer_components.FormSales;

namespace sale_of_computer_components
{
    public partial class FormManageProducts : Form
    {
        private List<Product> products;
        public FormManageProducts(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            UpdateProductList();
        }
        private void UpdateProductList()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in products)
            {
                listBoxProducts.Items.Add(product.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Name = textBoxName.Text,
                Features = textBoxFeatures.Text,
                Description = textBoxDescription.Text,
                Price = decimal.Parse(textBoxPrice.Text)
            };

            products.Add(product);
            UpdateProductList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex >= 0)
            {
                var product = products[listBoxProducts.SelectedIndex];
                product.Name = textBoxName.Text;
                product.Features = textBoxFeatures.Text;
                product.Description = textBoxDescription.Text;
                product.Price = decimal.Parse(textBoxPrice.Text);

                UpdateProductList();
            }
        }
        private void FormManageProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
