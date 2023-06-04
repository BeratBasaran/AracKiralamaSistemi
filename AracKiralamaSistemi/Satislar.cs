using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AracKiralamaSistemi
{
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();
        public void Satislar_Listele()
        {

            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            string KomutCumlesi = "Select * From Satislar";
            SqlCommand Komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            Satislar_Listele();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string Plaka = selectedRow.Cells["Plaka"].Value.ToString();
                SqlConnection baglanti = new SqlConnection(bgl.ADRES);
                baglanti.Open();

                string KomutCumlesiUp = "UPDATE Araclar SET Durum = 'Bos' WHERE Plaka = @Plaka";
                SqlCommand KomutUp = new SqlCommand(KomutCumlesiUp, baglanti);

                KomutUp.Parameters.AddWithValue("@Durum", "");
                KomutUp.Parameters.AddWithValue("@Plaka", Plaka);
                KomutUp.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();

                string KomutCumlesiSil = "Delete From Satislar WHERE Plaka = @Plaka";
                SqlCommand KomutSil = new SqlCommand(KomutCumlesiSil, baglanti);
                KomutSil.Parameters.AddWithValue("@Plaka", Plaka);

                KomutSil.ExecuteNonQuery() ;
                baglanti.Close();
                dataGridView1.Rows.Remove(selectedRow);

                MessageBox.Show("Silme İşlemi Başarılı!");
                Satislar_Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Satır Seçini!");
            }
        }
    }
}
