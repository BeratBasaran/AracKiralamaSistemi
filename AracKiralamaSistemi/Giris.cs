using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaSistemi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public void Bayii1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfafrm = new AnaSayfa();
            anasayfafrm.anasayfalabel.Text = "Berat Rent A Car KOCAELİ Bayi © 2023 Copyright";
            anasayfafrm.Show();
        }

        private void Bayii2_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfafrm = new AnaSayfa();
            anasayfafrm.anasayfalabel.Text = "Berat Rent A Car İSTANBUL Bayi © 2023 Copyright";
            anasayfafrm.Show();
        }

        private void Bayii3_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfafrm = new AnaSayfa();
            anasayfafrm.anasayfalabel.Text = "Berat Rent A Car İZMİR Bayi © 2023 Copyright";
            anasayfafrm.Show();
        }
    }
}
