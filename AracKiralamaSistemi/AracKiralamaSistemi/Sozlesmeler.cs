using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace AracKiralamaSistemi
{
    public partial class Sozlesmeler : Form
    {
        public Sozlesmeler()
        {
            InitializeComponent();
        }

        BaglantiSinif bgl = new BaglantiSinif();

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            string KomutCumlesi = "Select * From Araclar Where Durum='Boş'";
            SqlCommand Komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                Plakacombo.Items.Add(read["Plaka"]);
            }
        }
        public void Sozlesme_Listele()
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            string KomutCumlesi = "Select * From Sozlesmeler";
            SqlCommand Komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(Komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public void Hesapla()
        {

            if (string.IsNullOrEmpty(TCNotext.Text) ||
                string.IsNullOrEmpty(AdSoyadtext.Text) ||
                string.IsNullOrEmpty(TelefonMasked.Text) ||
                string.IsNullOrEmpty(EhliyetNotext.Text) ||
                string.IsNullOrEmpty(Plakacombo.Text) ||
                string.IsNullOrEmpty(Markatext.Text) ||
                string.IsNullOrEmpty(Modeltext.Text) ||
                string.IsNullOrEmpty(ModelYilitext.Text) ||
                string.IsNullOrEmpty(Renktext.Text) ||
                string.IsNullOrEmpty(Kilometretext.Text) ||
                string.IsNullOrEmpty(Yakittext.Text) ||
                string.IsNullOrEmpty(Sehirtext.Text) ||
                string.IsNullOrEmpty(KiraSeklicombo.Text) ||
                string.IsNullOrEmpty(KiraUcretitext.Text))

            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                TimeSpan GunFarki = DateTime.Parse(TeslimAlmaDate.Text) - DateTime.Parse(TeslimEtmeDate.Text);
                int GunHesap = GunFarki.Days;
                KiralanacakGunSayisitext.Text = GunHesap.ToString();
                Tutartext.Text = (GunHesap * int.Parse(KiraUcretitext.Text)).ToString();
            }
        }
        public void Ekle()
        {
            if
                (string.IsNullOrEmpty(TCNotext.Text) ||
                string.IsNullOrEmpty(AdSoyadtext.Text) ||
                string.IsNullOrEmpty(TelefonMasked.Text) ||
                string.IsNullOrEmpty(EhliyetNotext.Text) ||
                string.IsNullOrEmpty(Plakacombo.Text) ||
                string.IsNullOrEmpty(Markatext.Text) ||
                string.IsNullOrEmpty(Modeltext.Text) ||
                string.IsNullOrEmpty(ModelYilitext.Text) ||
                string.IsNullOrEmpty(Renktext.Text) ||
                string.IsNullOrEmpty(Kilometretext.Text) ||
                string.IsNullOrEmpty(Yakittext.Text) ||
                string.IsNullOrEmpty(Sehirtext.Text) ||
                string.IsNullOrEmpty(KiraSeklicombo.Text) ||
                string.IsNullOrEmpty(KiraUcretitext.Text) ||
                string.IsNullOrEmpty(KiralanacakGunSayisitext.Text) ||
                string.IsNullOrEmpty(Tutartext.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
                return;
            }
            if (EhliyetNotext.Text.Length < 6) 
            {
                MessageBox.Show("Lütfen Ehliyet No'yu Doğru Giriniz!");
                return;
            }

            string TCNo = TCNotext.Text;
            
            string Satislar_TCNO = "Select Count(*) From Satislar Where TC_No = @TC_No";
            string Sozlesmeler_TCNO = "Select Count(*) From Sozlesmeler Where TC_No = @TC_No";

            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            {
                SqlCommand Komut2 = new SqlCommand(Satislar_TCNO, baglanti);
                Komut2.Parameters.AddWithValue("@TC_No", TCNo);
                baglanti.Open();

                int satislarCount = (int)Komut2.ExecuteScalar();

                if (satislarCount > 0)
                {
                    MessageBox.Show("Bir Kişi Birden Fazla Araç Kiralayamaz!");
                    return;
                }
                baglanti.Close();
            }
            
            SqlCommand Komut3 = new SqlCommand(Sozlesmeler_TCNO, baglanti);
            Komut3.Parameters.AddWithValue("@TC_No", TCNo);
            baglanti.Open();

            int sozlesmelerCount = (int)Komut3.ExecuteScalar();

            if (sozlesmelerCount > 0)
            {
                MessageBox.Show("Bir Kişi Birden Fazla Araç Kiralayamaz!");
                return;
            }            
            else
            {
                DateTime EhliyetTarihi = DateTime.Parse(EhliyetVerilisTarihimasked.Text);
                DateTime SimdikiZaman = DateTime.Now;
                TimeSpan EhliyetYili = SimdikiZaman - EhliyetTarihi;

                if (EhliyetYili.TotalDays < 730)
                {
                    MessageBox.Show("Sürücünün En Az 2 Yıldır Ehliyet Sahibi Olması Zorunludur!");
                    return;
                }
                else
                {
                    string KomutCumlesi2 = "SELECT Plaka, Teslim_Etme_Tarihi,Teslim_Alma_Tarihi FROM Satislar";
                    DataTable dt = new DataTable();

                    using (SqlCommand Komut4 = new SqlCommand(KomutCumlesi2, baglanti))
                    {
                        using (SqlDataReader reader4 = Komut4.ExecuteReader())
                        {
                            dt.Load(reader4);
                        }
                    }
                    DateTime Bugun = DateTime.Today;
                    foreach (DataRow row in dt.Rows)
                    {
                        string Plaka = row["Plaka"].ToString();
                        DateTime TeslimEtmeTarihi = Convert.ToDateTime(row["Teslim_Etme_Tarihi"]);
                        DateTime TeslimAlmaTarihi = Convert.ToDateTime(row["Teslim_Alma_Tarihi"]);

                        bool AracDolu = (TeslimEtmeTarihi <= Bugun && Bugun <= TeslimAlmaTarihi);
                        string KomutCumlesiUp2 = "Update Araclar Set Durum = 'Dolu' where Plaka= '" + Plaka + "'";
                        SqlCommand KomutUp2 = new SqlCommand(KomutCumlesiUp2, baglanti);
                        KomutUp2.ExecuteNonQuery();
                    }
                    baglanti.Close();
                    baglanti.Open();

                    string KomutCumlesi = " Insert into Sozlesmeler Values(@TC_No, @Ad_Soyad, @Telefon, @Ehliyet_No, @Ehliyet_Verilis_Tarihi, @Plaka, @Marka, @Model, @Model_Yili, @Renk, @Kilometre, @Yakit, @Bulundugu_Sehir, @Kira_Sekli, @Kira_Ucreti, @Kiralanacak_Gun_Sayisi, @Tutar, @Teslim_Etme_Tarihi, @Teslim_Alma_Tarihi)";
                    SqlCommand Komut5 = new SqlCommand(KomutCumlesi, baglanti);

                    Komut5.Parameters.AddWithValue("@TC_No", TCNotext.Text);
                    Komut5.Parameters.AddWithValue("@Ad_Soyad", AdSoyadtext.Text);
                    Komut5.Parameters.AddWithValue("@Telefon", TelefonMasked.Text);
                    Komut5.Parameters.AddWithValue("@Ehliyet_No", EhliyetNotext.Text);
                    Komut5.Parameters.AddWithValue("@Ehliyet_Verilis_Tarihi", EhliyetVerilisTarihimasked.Text);
                    Komut5.Parameters.AddWithValue("@Plaka", Plakacombo.Text);
                    Komut5.Parameters.AddWithValue("@Marka", Markatext.Text);
                    Komut5.Parameters.AddWithValue("@Model", Modeltext.Text);
                    Komut5.Parameters.AddWithValue("@Model_Yili", ModelYilitext.Text);
                    Komut5.Parameters.AddWithValue("@Renk", Renktext.Text);
                    Komut5.Parameters.AddWithValue("@Kilometre", Kilometretext.Text);
                    Komut5.Parameters.AddWithValue("@Yakit", Yakittext.Text);
                    Komut5.Parameters.AddWithValue("@Bulundugu_Sehir", Sehirtext.Text);
                    Komut5.Parameters.AddWithValue("@Kira_Sekli", KiraSeklicombo.Text);
                    Komut5.Parameters.AddWithValue("@Kira_Ucreti", KiraUcretitext.Text);
                    Komut5.Parameters.AddWithValue("@Kiralanacak_Gun_Sayisi", KiralanacakGunSayisitext.Text);
                    Komut5.Parameters.AddWithValue("@Tutar", Tutartext.Text);
                    Komut5.Parameters.AddWithValue("@Teslim_Etme_Tarihi", TeslimEtmeDate.Text);
                    Komut5.Parameters.AddWithValue("@Teslim_Alma_Tarihi", TeslimAlmaDate.Text);

                    string KomutCumlesiUp = " Update Araclar set Durum = 'Dolu' Where Plaka = '" + Plakacombo.SelectedItem + "'";
                    SqlCommand KomutUp = new SqlCommand(KomutCumlesiUp, baglanti);

                    Komut5.ExecuteNonQuery();
                    KomutUp.ExecuteNonQuery();
                    baglanti.Close();

                    Sozlesme_Listele();
                    Arac_Listele();

                    MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleştirildi!");

                    TCileAratext.Clear();
                    TCNotext.Clear();
                    AdSoyadtext.Clear();
                    TelefonMasked.Clear();
                    EhliyetNotext.Clear();
                    EhliyetVerilisTarihimasked.Clear();
                    Plakacombo.SelectedIndex = -1;
                    Markatext.Clear();
                    Modeltext.Clear();
                    ModelYilitext.Clear();
                    Renktext.Clear();
                    Kilometretext.Clear();
                    Yakittext.Clear();
                    Sehirtext.Clear();
                    KiraSeklicombo.SelectedIndex = -1;
                    KiraUcretitext.Clear();
                    KiralanacakGunSayisitext.Clear();
                    Tutartext.Clear();
                    TeslimEtmeDate.Value = DateTime.Now;
                    TeslimAlmaDate.Value = DateTime.Now;
                }
            }
        }
        public void Teslim_Et()
        {
            {
                SqlConnection baglanti = new SqlConnection(bgl.ADRES);
                baglanti.Open();

                DataGridViewRow satir = dataGridView1.CurrentRow;

                string KomutCumlesiSatis = "Insert into Satislar Values (@TC_No, @Ad_Soyad, @Telefon, @Ehliyet_No, @Ehliyet_Verilis_Tarihi, @Plaka, @Marka, @Model, @Model_Yili, @Renk, @Kilometre, @Yakit, @Bulundugu_Sehir, @Kira_Sekli, @Kira_Ucreti, @Kiralanacak_Gun_Sayisi, @Tutar, @Teslim_Etme_Tarihi, @Teslim_Alma_Tarihi)";
                SqlCommand komutSatis = new SqlCommand(KomutCumlesiSatis, baglanti);

                komutSatis.Parameters.AddWithValue("@TC_No", satir.Cells["TC_No"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Ad_Soyad", satir.Cells["Ad_Soyad"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Telefon", satir.Cells["Telefon"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Ehliyet_No", satir.Cells["Ehliyet_No"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Ehliyet_Verilis_Tarihi", satir.Cells["Ehliyet_Verilis_Tarihi"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Marka", satir.Cells["Marka"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Model", satir.Cells["Model"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Model_Yili", satir.Cells["Model_Yili"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Renk", satir.Cells["Renk"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Kilometre", satir.Cells["Kilometre"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Yakit", satir.Cells["Yakit"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Bulundugu_Sehir", satir.Cells["Bulundugu_Sehir"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Kira_Sekli", satir.Cells["Kira_Sekli"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Kira_Ucreti", satir.Cells["Kira_Ucreti"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Kiralanacak_Gun_Sayisi", satir.Cells["Kiralanacak_Gun_Sayisi"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Tutar", satir.Cells["Tutar"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Teslim_Etme_Tarihi", satir.Cells["Teslim_Etme_Tarihi"].Value.ToString());
                komutSatis.Parameters.AddWithValue("@Teslim_Alma_Tarihi", satir.Cells["Teslim_Alma_Tarihi"].Value.ToString());


                komutSatis.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Araç Başarılı Bir Şekilde Teslim Edildi!");

                TCileAratext.Clear();
                TCNotext.Clear();
                AdSoyadtext.Clear();
                TelefonMasked.Clear();
                EhliyetNotext.Clear();
                EhliyetVerilisTarihimasked.Clear();
                Plakacombo.SelectedIndex = -1;
                Markatext.Clear();
                Modeltext.Clear();
                ModelYilitext.Clear();
                Renktext.Clear();
                Kilometretext.Clear();
                Yakittext.Clear();
                Sehirtext.Clear();
                KiraSeklicombo.SelectedIndex = -1;
                KiraUcretitext.Clear();
                KiralanacakGunSayisitext.Clear();
                Tutartext.Clear();
                TeslimEtmeDate.Value = DateTime.Now;
                TeslimAlmaDate.Value = DateTime.Now;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TCileAratext_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            string KomutCumlesi = "Select * From Musteriler Where TC_No like'" + TCileAratext.Text + "'";
            SqlCommand komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                TCNotext.Text = read["TC_No"].ToString();
                AdSoyadtext.Text = read["Ad_Soyad"].ToString();
                TelefonMasked.Text = read["Telefon_Numarasi"].ToString();
            }
        }

        private void Sozlesmeler_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();


            string KomutCumlesi = "Select TC_No, Ad_Soyad, Telefon, Ehliyet_No, Ehliyet_Verilis_Tarihi, Plaka, Marka, Model, Model_Yili, Renk, Kilometre, Yakit, Bulundugu_Sehir, Kira_Sekli, Kira_Ucreti, Kiralanacak_Gun_Sayisi, Tutar, Teslim_Etme_Tarihi, Teslim_Alma_Tarihi From Sozlesmeler";
            SqlCommand Komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(Komut);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            Arac_Listele();
        }

        private void Plakacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            string KomutCumlesi = "Select * From Araclar Where Plaka like '" + Plakacombo.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(KomutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Markatext.Text = read["Marka"].ToString();
                Modeltext.Text = read["Model"].ToString();
                ModelYilitext.Text = read["Model_Yili"].ToString();
                Renktext.Text = read["Renk"].ToString();
                Kilometretext.Text = read["Kilometre"].ToString();
                Yakittext.Text = read["Yakit"].ToString();
                Sehirtext.Text = read["Bulundugu_Sehir"].ToString();
            }
        }

        private void Hesaplabtn_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void KiraSeklicombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.ADRES);
            baglanti.Open();

            string KomutCumlesi = "Select Kira_Ucreti From Araclar";
            SqlCommand komut = new SqlCommand(KomutCumlesi, baglanti);

            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (KiraSeklicombo.SelectedIndex == 0)
                {
                    KiraUcretitext.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 1).ToString();
                }
                else if (KiraSeklicombo.SelectedIndex == 1)
                {
                    KiraUcretitext.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.80).ToString();
                }
                else if (KiraSeklicombo.SelectedIndex == 2)
                {
                    KiraUcretitext.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.75).ToString();
                }
                else if (KiraSeklicombo.SelectedIndex == 3)
                {
                    KiraUcretitext.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.50).ToString();
                }
            }
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void AracTeslimbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili Aracı Teslim Etmek İstediğinize Emin Misiniz?", "Teslim Etme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Teslim_Et();

                    DataGridViewRow satir = dataGridView1.CurrentRow;

                    SqlConnection baglanti = new SqlConnection(bgl.ADRES);
                    baglanti.Open();

                    string KomutCumlesiSil = "Delete From Sozlesmeler Where Plaka = '" + satir.Cells["Plaka"].Value.ToString() + "'";
                    SqlCommand komut = new SqlCommand(KomutCumlesiSil, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    Arac_Listele();
                }
            }
        }
        private void TCNOtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TCileAratext_KeyPress(object sender, KeyPressEventArgs e)
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
        private void EhliyetNotext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
