using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            string folderPath = txtFolderPath.Text;
            string searchPattern = txtSearchPattern.Text;

            if (Directory.Exists(folderPath))
            {
                try
                {
                    string[] files = Directory.GetFiles(folderPath, searchPattern, SearchOption.TopDirectoryOnly);
                    lstFiles.Items.AddRange(files);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка поиска файлов: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Указанная папка не существует.");
            }
        }
    }
}
