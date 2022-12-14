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

namespace ZH3_BSCSRJ
{
    public partial class UserControlReceptek : UserControl
    {
        ReceptContext context = new ReceptContext();
        public UserControlReceptek()
        {
            InitializeComponent();
            FogasSzures();
            Megjelenit();
            NyersSzures();
        }

        private void textBoxFogas_TextChanged(object sender, EventArgs e)
        {
            FogasSzures();
        }

        private void FogasSzures()
        {
            var fogasok = from x in context.Fogasok
                          where x.FogasNev.Contains(textBoxFogas.Text)
                          select x;

            listBoxFogasok.DataSource = fogasok.ToList();
            listBoxFogasok.DisplayMember = "FogasNev";
        }

        private void listBoxFogasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Megjelenit();
        }

        private void Megjelenit()
        {
            var selectedFogas = (Fogasok)listBoxFogasok.SelectedItem;

            var receptek = from x in context.Receptek
                           where x.FogasId == selectedFogas.FogasId
                           select new Hozzavalo
                           {
                               ReceptID = x.ReceptId,
                               FogasID = x.FogasId,
                               NyersanyagNev = x.Nyersanyag.NyersanyagNev,
                               Mennyiseg_4fo = x.Mennyiseg4fo,
                               EgysegNev = x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                               Ar = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                           };

            hozzavaloBindingSource.DataSource = receptek.ToList();
        }

        private void textBoxNyers_TextChanged(object sender, EventArgs e)
        {
            NyersSzures();
        }

        private void NyersSzures()
        {
            var nyersek = from x in context.Nyersanyagok
                          where x.NyersanyagNev.Contains(textBoxNyers.Text)
                          select x;

            listBoxNyersek.DataSource = nyersek.ToList();
            listBoxNyersek.DisplayMember = "NyersanyagNev";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedFogas = (Fogasok)listBoxFogasok.SelectedItem;
            var selectedNyers = (Nyersanyagok)listBoxNyersek.SelectedItem;

            Receptek recept = new Receptek();

            double m = 0;
            if (!double.TryParse(textBoxMenny.Text, out m))
            {
                return;
            }

            recept.Mennyiseg4fo = m;
            recept.NyersanyagId = selectedNyers.NyersanyagId;
            recept.FogasId = selectedFogas.FogasId;

            context.Receptek.Add(recept);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Megjelenit();
        }
    }
}
