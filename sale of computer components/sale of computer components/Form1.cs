using System.Xml.Linq;

namespace sale_of_computer_components
{

    public partial class FormSales : System.Windows.Forms.Form
    {
        public class Product
        {
            public string Name { get; set; }
            public string Features { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public override string ToString()
            {
                return $"{Name} - {Features} ({Description})";
            }
        }

        private List<Product> products = new List<Product>();
        private decimal totalCost = 0;

        public FormSales()
        {
            InitializeComponent();
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            comboBoxProducts.Items.Clear();
            foreach (var product in products)
            {
                comboBoxProducts.Items.Add(product);
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem is Product selectedProduct)
            {
                textBoxPrice.Text = selectedProduct.Price.ToString("C2");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem is Product selectedProduct)
            {
                listBoxSales.Items.Add(selectedProduct);
                totalCost += selectedProduct.Price;
                labelTotalCost.Text = $"Общая стоимость: {totalCost:C2}";
            }
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            var manageForm = new FormManageProducts(products);
            manageForm.ShowDialog();
            UpdateProductList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}