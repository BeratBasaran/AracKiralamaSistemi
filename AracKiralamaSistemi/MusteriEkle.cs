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
using System.Data.Sql;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;
using System.Drawing.Text;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AracKiralamaSistemi
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
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
                string komutCumlesi = "SELECT TC_No FROM Musteriler WHERE TC_No=@TC_No";
                using (SqlConnection baglanti = new SqlConnection(bgl.ADRES))

                {
                    using (SqlCommand komut = new SqlCommand(komutCumlesi, baglanti))
                    {
                        baglanti.Open();
                        komut.Parameters.AddWithValue("@TC_No", TCNOtext.Text);
                        using (SqlDataReader reader = komut.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Bu T.C. No'ya Sahip Bir Kayıt Zaten Var!");
                                return;
                            }
                            else if (TCNOtext.TextLength < 11)
                            {
                                MessageBox.Show("Lütfen 11 Haneli T.C. No Giriniz!");
                                return;
                            }

                        }
                    }
                    string AdSoyad = AdSoyadtext.Text.ToUpper();
                    string KomutCumlesi2 = "Insert Into Musteriler Values (@TCNO, @AdSoyad, @Telefon, @EMail, @Adres)";
                    using (SqlCommand komut2 = new SqlCommand(KomutCumlesi2, baglanti))
                    {
                        komut2.Parameters.AddWithValue("@TCNO", TCNOtext.Text);
                        komut2.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                        komut2.Parameters.AddWithValue("@Telefon", maskedTextBox1.Text);
                        komut2.Parameters.AddWithValue("@EMail", EMailtext.Text);
                        komut2.Parameters.AddWithValue("@Adres", Adrestext.Text);

                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kişi Başarılı Bir Şekilde Eklendi!");

                        TCNOtext.Clear();
                        AdSoyadtext.Clear();
                        maskedTextBox1.Clear();
                        EMailtext.Clear();
                        Adrestext.Clear();
                    }
                }
            }
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

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
                e.SuppressKeyPress = true;
            }
        }

    }
}
