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

namespace text_editing
{
    public partial class MainForm : Form
    {
        public string LoadedText { get; set; } = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }
        public void UpdateTextBox(string newText)
        {
            textBoxReadOnly.Text = newText;
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadedText = File.ReadAllText(openFileDialog.FileName);
                    textBoxReadOnly.Text = LoadedText;
                    btnEdit.Enabled = true;
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(LoadedText, this);
            editForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
