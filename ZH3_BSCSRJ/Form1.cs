namespace ZH3_BSCSRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormData formData = new FormData();

            formData.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Biztos ki akarsz lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}