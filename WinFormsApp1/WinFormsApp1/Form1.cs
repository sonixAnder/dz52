namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenSearchForm_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ну и ладно");
            Application.Exit();
        }
    }
}