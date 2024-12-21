using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace text_editing
{
    public partial class EditForm : Form
    {
        private readonly MainForm _mainForm;
        public EditForm(string text, MainForm mainForm)
        {
            InitializeComponent();
            textBoxEditable.Text = text;
            _mainForm = mainForm;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _mainForm.LoadedText = textBoxEditable.Text;
            _mainForm.UpdateTextBox(textBoxEditable.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
