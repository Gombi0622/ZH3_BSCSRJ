using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_BSCSRJ.Models;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ZH3_BSCSRJ
{
    public partial class UserControlFogasok : UserControl
    {
        ReceptContext context = new ReceptContext();

        Excel.Application application;
        Excel.Workbook workbook;
        Excel.Worksheet sheet;
        public UserControlFogasok()
        {
            InitializeComponent();
            fogasokBindingSource.DataSource = context.Fogasok.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                Fogasok fogas = new Fogasok();

                fogas.FogasNev = formAdd.textBoxFogas.Text;
                fogas.Leiras = formAdd.textBoxLeiras.Text;

                context.Fogasok.Add(fogas);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                fogasokBindingSource.DataSource = context.Fogasok.ToList();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var id = ((Fogasok)fogasokBindingSource.Current).FogasId;

            var del = (from x in context.Fogasok
                      where x.FogasId == id
                      select x).FirstOrDefault();

            var result = MessageBox.Show("Biztos ki akarod törölni?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                context.Fogasok.Remove(del);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                fogasokBindingSource.DataSource = context.Fogasok.ToList();
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                application = new Excel.Application();

                workbook = application.Workbooks.Add(Missing.Value);
                sheet = workbook.ActiveSheet;

                CreateTable();

                application.Visible = true;
                application.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                workbook.Close(false, Type.Missing, Type.Missing);
                application.Quit();
                workbook = null;
                application = null;
            }

            void CreateTable()
            {
                string[] fejlecek = new string[]
                {
                    "FogásID",
                    "FogásNév",
                    "Leírás"
                };

                for (int i = 0; i < fejlecek.Length; i++)
                {
                    sheet.Cells[1, i + 1] = fejlecek[i];
                }

                var fogasok = context.Fogasok.ToList();

                object[,] adatTomb = new object[fogasok.Count(), fejlecek.Count()];

                for (int i = 0; i < fogasok.Count(); i++)
                {
                    adatTomb[i, 0] = fogasok[i].FogasId;
                    adatTomb[i, 1] = fogasok[i].FogasNev;
                    adatTomb[i, 2] = fogasok[i].Leiras;
                }

                int sorok = adatTomb.GetLength(0);
                int oszlopok = adatTomb.GetLength(1);

                Excel.Range adatRange = sheet.get_Range("A2", Type.Missing).get_Resize(sorok, oszlopok);
                adatRange.Value2 = adatTomb;
                adatRange.Columns.AutoFit();

                Excel.Range fejlecRange = sheet.get_Range("A1", Type.Missing).get_Resize(1, 3);
                fejlecRange.Interior.Color = Color.Fuchsia;
            }
        }
    }
}
