using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_BSCSRJ
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxFogas_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFogas.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxFogas, "Nem lehet üres");
            }
        }

        private void textBoxFogas_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxFogas, string.Empty);
        }

        private void textBoxLeiras_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("[a-zA-Z0-9]{6,}");
            if (!regex.IsMatch(textBoxLeiras.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxLeiras, "Minimum 6 karakter hosszú");
            }
        }

        private void textBoxLeiras_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLeiras, string.Empty);
        }
    }
}
