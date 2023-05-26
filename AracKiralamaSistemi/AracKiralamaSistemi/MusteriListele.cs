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
using System.Windows.Forms.VisualStyles;
using System.Net.Mail;

namespace AracKiralamaSistemi
{
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            Musteri_Listele();
        }
        public void Musteri_Listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            string KomutCumlesi = "Select TC_No, Ad_Soyad, Telefon_Numarasi, E_Mail, Adres  From Musteriler";
            SqlCommand komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TCNOtext.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            AdSoyadtext.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EMailtext.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Adrestext.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void BilgileriGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            if (string.IsNullOrEmpty(TCNOtext.Text) ||
                 string.IsNullOrEmpty(AdSoyadtext.Text) ||
                 string.IsNullOrEmpty(maskedTextBox1.Text) ||
                 string.IsNullOrEmpty(EMailtext.Text) ||
                 string.IsNullOrEmpty(Adrestext.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                string KomutCumlesi = "Update Musteriler set  Ad_Soyad = @Ad_Soyad, Telefon_Numarasi = @Telefon_Numarasi, E_Mail = @E_Mail, Adres = @Adres Where TC_No = @TC_No";
                SqlCommand komut = new SqlCommand(KomutCumlesi, baglanti);
                komut.Parameters.AddWithValue("@TC_no", TCNOtext.Text);
                komut.Parameters.AddWithValue("@Ad_Soyad", AdSoyadtext.Text);
                komut.Parameters.AddWithValue("@Telefon_Numarasi", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@E_Mail", EMailtext.Text);
                komut.Parameters.AddWithValue("@Adres", Adrestext.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Musteri_Listele();

                MessageBox.Show("Müşteri Bilgileri Başarıyla Güncellendi!");

                TCNOtext.Clear();
                AdSoyadtext.Clear();
                maskedTextBox1.Clear();
                EMailtext.Clear();
                Adrestext.Clear();
            }
        }

        private void BilgileriSilbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Satırı Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Seçili Satırı Silmek İstediğinize Emin misiniz?", "Silmeyi Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                long TC = Convert.ToInt64(dataGridView1.Rows[rowIndex].Cells["TC_No"].Value);
                SqlConnection baglanti = new SqlConnection(bgl.ADRES);
                baglanti.Open();

                string KomutCumlesi = " Delete From Musteriler Where TC_No='" + dataGridView1.CurrentRow.Cells["TC_No"].Value.ToString() + "'";
                SqlCommand Komut = new SqlCommand(KomutCumlesi, baglanti);

                Komut.ExecuteNonQuery();
                baglanti.Close();
                Musteri_Listele();
                MessageBox.Show("Seçili Satır Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TCNOtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AdSoyadtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void EMailtext_Leave(object sender, EventArgs e)
        {
            if (EMailtext.Text.Length > 0)
            {
                try
                {
                    MailAddress mail = new MailAddress(EMailtext.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Geçersiz E-Mail Adresi Girdiniz!");
                    EMailtext.Focus();
                }
            }
        }

        private void Temizlebtn_Click(object sender, EventArgs e)
        {
            TCNOtext.Clear();
            AdSoyadtext.Clear();
            maskedTextBox1.Clear();
            EMailtext.Clear();
            Adrestext.Clear();
        }
        private void EMailtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true; // Boşluk tuşunun bastırılmasını engelleme işareti
            }
        }
    }
}
