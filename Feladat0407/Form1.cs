using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feladat0407
{
    public partial class Form1 : Form
    {

        int eredmeny;
        int elso;
        int masodik;
        String feladat;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Legeneral();
        }

        private void tbEredmeny_TextChanged(object sender, EventArgs e)
        {

        }

        private void btUjKerdes_Click(object sender, EventArgs e)
        {
            Legeneral();
        }

        private void btEllenoriz_Click(object sender, EventArgs e)
        {
            if (tbValasz.Text.Equals(eredmeny.ToString()))
            {
                tbEredmeny.Text = "Jó Megoldás!";
            }
            else
            {
                tbEredmeny.Text = "Nem Jó Megoldás!";
            }
        }

        private void Legeneral()
        {

            if (cbMuveletek.SelectedItem.Equals("Osztás"))
            {
                elso = 5;
                masodik = 5;
                feladat = $"{elso}/{masodik}";
                eredmeny = elso / masodik;
                tbFeladat.Text = feladat;
            }
            else { }
        }

    }
}
