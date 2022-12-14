using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_BSCSRJ
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }

        private void buttonReceptek_Click(object sender, EventArgs e)
        {
            UserControlReceptek userControlReceptek = new UserControlReceptek();

            panel1.Controls.Clear();
            panel1.Controls.Add(userControlReceptek);

            userControlReceptek.Dock = DockStyle.Fill;
        }

        private void buttonFogasok_Click(object sender, EventArgs e)
        {
            UserControlFogasok userControlFogasok = new UserControlFogasok();

            panel1.Controls.Clear();
            panel1.Controls.Add(userControlFogasok);

            userControlFogasok.Dock = DockStyle.Left;
        }
    }
}
