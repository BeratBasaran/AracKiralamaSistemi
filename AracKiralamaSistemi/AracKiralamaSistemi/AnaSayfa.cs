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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriEklebtn_Click(object sender, EventArgs e)
        {
            MusteriEkle musterieklefrm = new MusteriEkle();
            musterieklefrm.Show();
        }

        private void MusteriListelebtn_Click(object sender, EventArgs e)
        {
            MusteriListele musterilistelefrm = new MusteriListele();
            musterilistelefrm.Show();
        }

        private void AracEklebtn_Click(object sender, EventArgs e)
        {
            AracEkle araceklefrm = new AracEkle();
            araceklefrm.Show();
        }

        private void AracListelebtn_Click(object sender, EventArgs e)
        {
            AracListele araclistelefrm = new AracListele();
            araclistelefrm.Show();
        }

        private void Sozlesmelerbtn_Click(object sender, EventArgs e)
        {
            Sozlesmeler sozlesmelerfrm = new Sozlesmeler();
            sozlesmelerfrm.Show();
        }

        private void Satislarbtn_Click(object sender, EventArgs e)
        {
            Satislar satislarfrm = new Satislar();
            satislarfrm.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
