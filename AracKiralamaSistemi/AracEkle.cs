using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace AracKiralamaSistemi
{
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        private void DoluBosKontrol()
        {
            if (string.IsNullOrEmpty(Plakatext.Text) ||
                string.IsNullOrEmpty(Markacombo.Text) ||
                string.IsNullOrEmpty(Modelcombo.Text) ||
                string.IsNullOrEmpty(ModelYilicombo.Text) ||
                string.IsNullOrEmpty(Renkcombo.Text) ||
                string.IsNullOrEmpty(Kilometretext.Text) ||
                string.IsNullOrEmpty(Yakitcombo.Text) ||
                string.IsNullOrEmpty(KiraUcretitext.Text) ||
                string.IsNullOrEmpty(Durumcombo.Text) ||
                string.IsNullOrEmpty(Sehircombo.Text))
            {
                MessageBox.Show("Lütfen Bos Alanları Doldurunuz!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Markacombo.SelectedIndex == 0)
            {
                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Giulia");
                Modelcombo.Items.Add("Giulia Quadrifoglio");
                Modelcombo.Items.Add("Giulietta");
                Modelcombo.Items.Add("Brera");
                Modelcombo.Items.Add("GT");
                Modelcombo.Items.Add("GTV");
                Modelcombo.Items.Add("MiTo");
                Modelcombo.Items.Add("Spider");

            }
            else if (Markacombo.SelectedIndex == 1)
            {
                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("DB11");
                Modelcombo.Items.Add("DB7");
                Modelcombo.Items.Add("DB9");
                Modelcombo.Items.Add("DBS");
                Modelcombo.Items.Add("Rapide");
                Modelcombo.Items.Add("Vanquish");
                Modelcombo.Items.Add("Vantage");
                Modelcombo.Items.Add("Virage");

            }
            else if (Markacombo.SelectedIndex == 2)
            {
                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("A1");
                Modelcombo.Items.Add("A2");
                Modelcombo.Items.Add("A3");
                Modelcombo.Items.Add("A4");
                Modelcombo.Items.Add("A5");
                Modelcombo.Items.Add("A6");
                Modelcombo.Items.Add("A7");
                Modelcombo.Items.Add("A8");
                Modelcombo.Items.Add("E-Tron GT");
                Modelcombo.Items.Add("R8");
                Modelcombo.Items.Add("RS");
                Modelcombo.Items.Add("TT");
                Modelcombo.Items.Add("TTS");

            }
            else if (Markacombo.SelectedIndex == 3)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("116i");
                Modelcombo.Items.Add("216d Gran Coupe");
                Modelcombo.Items.Add("316i");
                Modelcombo.Items.Add("320i");
                Modelcombo.Items.Add("418i Gran Coupe");
                Modelcombo.Items.Add("520d");
                Modelcombo.Items.Add("520İ");
                Modelcombo.Items.Add("840i xDrive");
                Modelcombo.Items.Add("i7");
                Modelcombo.Items.Add("M2");
                Modelcombo.Items.Add("M3");
                Modelcombo.Items.Add("M4");
                Modelcombo.Items.Add("M5");
                Modelcombo.Items.Add("M6");

            }
            else if (Markacombo.SelectedIndex == 4)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Alia");
                Modelcombo.Items.Add("Chance");
                Modelcombo.Items.Add("Kimo");
                Modelcombo.Items.Add("Niche");

            }
            else if (Markacombo.SelectedIndex == 5)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Aveo");
                Modelcombo.Items.Add("Camaro");
                Modelcombo.Items.Add("Caprice");
                Modelcombo.Items.Add("Celebrity");
                Modelcombo.Items.Add("Corvette");
                Modelcombo.Items.Add("Cruze");
                Modelcombo.Items.Add("Kalos");
                Modelcombo.Items.Add("Lacetti");
                Modelcombo.Items.Add("Spark");

            }
            else if (Markacombo.SelectedIndex == 6)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("C1");
                Modelcombo.Items.Add("C2");
                Modelcombo.Items.Add("C3");
                Modelcombo.Items.Add("C4");
                Modelcombo.Items.Add("C5");
                Modelcombo.Items.Add("C-Elysée");
                Modelcombo.Items.Add("Saxo");
                Modelcombo.Items.Add("Xsara");

            }
            else if (Markacombo.SelectedIndex == 7)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Formentor");
                Modelcombo.Items.Add("Leon");

            }
            else if (Markacombo.SelectedIndex == 8)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Jogger");
                Modelcombo.Items.Add("Lodgy");
                Modelcombo.Items.Add("Logan");
                Modelcombo.Items.Add("Sandero");
                Modelcombo.Items.Add("Nova");
                Modelcombo.Items.Add("Solenza");

            }
            else if (Markacombo.SelectedIndex == 9)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("DS3");
                Modelcombo.Items.Add("DS4");
                Modelcombo.Items.Add("DS5");
                Modelcombo.Items.Add("DS7");
                Modelcombo.Items.Add("DS9");

            }
            else if (Markacombo.SelectedIndex == 10)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Albea");
                Modelcombo.Items.Add("Bravo");
                Modelcombo.Items.Add("500 Ailesi");
                Modelcombo.Items.Add("Egea");
                Modelcombo.Items.Add("Linea");
                Modelcombo.Items.Add("Palio");
                Modelcombo.Items.Add("Punto");
                Modelcombo.Items.Add("Siena");
                Modelcombo.Items.Add("Tempra");
                Modelcombo.Items.Add("Tipo");
                Modelcombo.Items.Add("UNO");

            }
            else if (Markacombo.SelectedIndex == 11)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("B-Max");
                Modelcombo.Items.Add("C-Max");
                Modelcombo.Items.Add("Escort");
                Modelcombo.Items.Add("Fiesta");
                Modelcombo.Items.Add("Focus");
                Modelcombo.Items.Add("Fusion");
                Modelcombo.Items.Add("Galaxy");
                Modelcombo.Items.Add("Grand C-Max");
                Modelcombo.Items.Add("Ka");
                Modelcombo.Items.Add("Mondeo");
                Modelcombo.Items.Add("Mustang");
                Modelcombo.Items.Add("S-Max");
                Modelcombo.Items.Add("Taurus");
                Modelcombo.Items.Add("Cougar");
                Modelcombo.Items.Add("Crown Victoria");
                Modelcombo.Items.Add("Festiva");
                Modelcombo.Items.Add("Granada");
                Modelcombo.Items.Add("Taunus");

            }
            else if (Markacombo.SelectedIndex == 12)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Accord");
                Modelcombo.Items.Add("City");
                Modelcombo.Items.Add("Civic");
                Modelcombo.Items.Add("Concerto");
                Modelcombo.Items.Add("CR-Z");
                Modelcombo.Items.Add("CRX");
                Modelcombo.Items.Add("E");
                Modelcombo.Items.Add("Integra");
                Modelcombo.Items.Add("Jazz");
                Modelcombo.Items.Add("Legend");
                Modelcombo.Items.Add("Prelude");
                Modelcombo.Items.Add("S2000");
                Modelcombo.Items.Add("Shuttle");
                Modelcombo.Items.Add("Stream");

            }
            else if (Markacombo.SelectedIndex == 13)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Accent");
                Modelcombo.Items.Add("Accent Blue");
                Modelcombo.Items.Add("Accent Era");
                Modelcombo.Items.Add("Atos");
                Modelcombo.Items.Add("Coupe");
                Modelcombo.Items.Add("Elantra");
                Modelcombo.Items.Add("Equus");
                Modelcombo.Items.Add("Excel");
                Modelcombo.Items.Add("Genesis");
                Modelcombo.Items.Add("Getz");
                Modelcombo.Items.Add("i10");
                Modelcombo.Items.Add("i20");
                Modelcombo.Items.Add("i30");
                Modelcombo.Items.Add("i40");
                Modelcombo.Items.Add("Ioniq");
                Modelcombo.Items.Add("S-Coupe");
                Modelcombo.Items.Add("Sonata");

            }
            else if (Markacombo.SelectedIndex == 14)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Daimler");
                Modelcombo.Items.Add("F-Type");
                Modelcombo.Items.Add("S-Type");
                Modelcombo.Items.Add("Sovereign");
                Modelcombo.Items.Add("X-Type");
                Modelcombo.Items.Add("XE");
                Modelcombo.Items.Add("XF");
                Modelcombo.Items.Add("XJ");
                Modelcombo.Items.Add("XJR");
                Modelcombo.Items.Add("XJS");
                Modelcombo.Items.Add("XK8");
                Modelcombo.Items.Add("XKR");

            }
            else if (Markacombo.SelectedIndex == 15)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Capital");
                Modelcombo.Items.Add("Carnival");
                Modelcombo.Items.Add("Ceed");
                Modelcombo.Items.Add("Cerato");
                Modelcombo.Items.Add("Picanto");
                Modelcombo.Items.Add("Pride");
                Modelcombo.Items.Add("Pro Ceed");
                Modelcombo.Items.Add("Rio");
                Modelcombo.Items.Add("Sephia");
                Modelcombo.Items.Add("Venga");

            }
            else if (Markacombo.SelectedIndex == 16)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Aventador");
                Modelcombo.Items.Add("Diablo");
                Modelcombo.Items.Add("Gallardo");
                Modelcombo.Items.Add("Huracan");

            }
            else if (Markacombo.SelectedIndex == 17)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("CT");
                Modelcombo.Items.Add("ES");
                Modelcombo.Items.Add("GS");
                Modelcombo.Items.Add("IS");
                Modelcombo.Items.Add("LS");

            }
            else if (Markacombo.SelectedIndex == 18)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("2");
                Modelcombo.Items.Add("3");
                Modelcombo.Items.Add("5");
                Modelcombo.Items.Add("6");
                Modelcombo.Items.Add("MPV");
                Modelcombo.Items.Add("MX");
                Modelcombo.Items.Add("323");
                Modelcombo.Items.Add("626");
                Modelcombo.Items.Add("Lantis");
                Modelcombo.Items.Add("RX");

            }
            else if (Markacombo.SelectedIndex == 19)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("A Serisi");
                Modelcombo.Items.Add("AMG GT");
                Modelcombo.Items.Add("B Serisi");
                Modelcombo.Items.Add("C Serisi");
                Modelcombo.Items.Add("CL");
                Modelcombo.Items.Add("CLA");
                Modelcombo.Items.Add("CLC");
                Modelcombo.Items.Add("CLK");
                Modelcombo.Items.Add("CLS");
                Modelcombo.Items.Add("E Serisi");
                Modelcombo.Items.Add("EQE");
                Modelcombo.Items.Add("EQS");
                Modelcombo.Items.Add("Maybach S");
                Modelcombo.Items.Add("R Serisi");
                Modelcombo.Items.Add("S Serisi");
                Modelcombo.Items.Add("SL");
                Modelcombo.Items.Add("SLC");
                Modelcombo.Items.Add("SLK");
                Modelcombo.Items.Add("SLS AMG");

            }
            else if (Markacombo.SelectedIndex == 20)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("F");
                Modelcombo.Items.Add("MG4");
                Modelcombo.Items.Add("ZR");
                Modelcombo.Items.Add("ZT");

            }
            else if (Markacombo.SelectedIndex == 21)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Cooper");
                Modelcombo.Items.Add("Cooper Clubman");
                Modelcombo.Items.Add("Cooper Electric");
                Modelcombo.Items.Add("John Cooper");
                Modelcombo.Items.Add("One");
                Modelcombo.Items.Add("Cooper S");

            }
            else if (Markacombo.SelectedIndex == 22)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Attrage");
                Modelcombo.Items.Add("Colt");
                Modelcombo.Items.Add("Galant");
                Modelcombo.Items.Add("Lancer");
                Modelcombo.Items.Add("Lancer Evolution");
                Modelcombo.Items.Add("Carisma");
                Modelcombo.Items.Add("Eclipse");
                Modelcombo.Items.Add("Grandis");
                Modelcombo.Items.Add("Sigma");
                Modelcombo.Items.Add("Space Star");
                Modelcombo.Items.Add("Space Wagon");

            }
            else if (Markacombo.SelectedIndex == 23)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Almera");
                Modelcombo.Items.Add("GT-R");
                Modelcombo.Items.Add("Maxima");
                Modelcombo.Items.Add("Micra");
                Modelcombo.Items.Add("Note");
                Modelcombo.Items.Add("NX Coupe");
                Modelcombo.Items.Add("Primera");
                Modelcombo.Items.Add("Pulsar");
                Modelcombo.Items.Add("Sunny");

            }
            else if (Markacombo.SelectedIndex == 24)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Astra");
                Modelcombo.Items.Add("Corsa");
                Modelcombo.Items.Add("Corsa-e");
                Modelcombo.Items.Add("GT (Roadster)");
                Modelcombo.Items.Add("Insignia");
                Modelcombo.Items.Add("Meriva");
                Modelcombo.Items.Add("Omega");
                Modelcombo.Items.Add("Signum");
                Modelcombo.Items.Add("Vectra");

            }
            else if (Markacombo.SelectedIndex == 25)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("106");
                Modelcombo.Items.Add("107");
                Modelcombo.Items.Add("205");
                Modelcombo.Items.Add("206");
                Modelcombo.Items.Add("207");
                Modelcombo.Items.Add("208");
                Modelcombo.Items.Add("301");
                Modelcombo.Items.Add("306");
                Modelcombo.Items.Add("307");
                Modelcombo.Items.Add("308");
                Modelcombo.Items.Add("406");
                Modelcombo.Items.Add("407");
                Modelcombo.Items.Add("408");
                Modelcombo.Items.Add("508");
                Modelcombo.Items.Add("3008");
                Modelcombo.Items.Add("5008");

            }
            else if (Markacombo.SelectedIndex == 26)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("718");
                Modelcombo.Items.Add("911");
                Modelcombo.Items.Add("928");
                Modelcombo.Items.Add("Boxster");
                Modelcombo.Items.Add("Cayman");
                Modelcombo.Items.Add("Panamera");
                Modelcombo.Items.Add("Taycan");

            }
            else if (Markacombo.SelectedIndex == 27)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Clio");
                Modelcombo.Items.Add("Espace");
                Modelcombo.Items.Add("Fluence");
                Modelcombo.Items.Add("Fluence Z.E.");
                Modelcombo.Items.Add("Grand Espace");
                Modelcombo.Items.Add("Grand Scenic");
                Modelcombo.Items.Add("Laguna");
                Modelcombo.Items.Add("Latitude");
                Modelcombo.Items.Add("Megane");
                Modelcombo.Items.Add("Modus");
                Modelcombo.Items.Add("Safrane");
                Modelcombo.Items.Add("Scenic");
                Modelcombo.Items.Add("Symbol");
                Modelcombo.Items.Add("Taliant");
                Modelcombo.Items.Add("Talisman");
                Modelcombo.Items.Add("Twingo");
                Modelcombo.Items.Add("Twizy");
                Modelcombo.Items.Add("Vel Satis");
                Modelcombo.Items.Add("ZOE");
                Modelcombo.Items.Add("R 5");
                Modelcombo.Items.Add("R 9");
                Modelcombo.Items.Add("R 11");
                Modelcombo.Items.Add("R 12");
                Modelcombo.Items.Add("R 19");
                Modelcombo.Items.Add("R 21");
                Modelcombo.Items.Add("R 25");

            }
            else if (Markacombo.SelectedIndex == 28)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Alhambra");
                Modelcombo.Items.Add("Altea");
                Modelcombo.Items.Add("Arosa");
                Modelcombo.Items.Add("Cordoba");
                Modelcombo.Items.Add("Exeo");
                Modelcombo.Items.Add("Ibiza");
                Modelcombo.Items.Add("Leon");
                Modelcombo.Items.Add("Marbella");
                Modelcombo.Items.Add("Toledo");

            }
            else if (Markacombo.SelectedIndex == 29)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Citigo");
                Modelcombo.Items.Add("Fabia");
                Modelcombo.Items.Add("Favorit");
                Modelcombo.Items.Add("Felicia");
                Modelcombo.Items.Add("Forman");
                Modelcombo.Items.Add("Octavia");
                Modelcombo.Items.Add("Rapid");
                Modelcombo.Items.Add("Roomster");
                Modelcombo.Items.Add("Scala");
                Modelcombo.Items.Add("Superb");

            }
            else if (Markacombo.SelectedIndex == 30)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Fortwo");
                Modelcombo.Items.Add("Forfour");
                Modelcombo.Items.Add("Roadster");

            }
            else if (Markacombo.SelectedIndex == 31)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("BRZ");
                Modelcombo.Items.Add("Impreza");
                Modelcombo.Items.Add("Legacy");
                Modelcombo.Items.Add("Levorg");
                Modelcombo.Items.Add("Justy");
                Modelcombo.Items.Add("Vivio");

            }
            else if (Markacombo.SelectedIndex == 32)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Alto");
                Modelcombo.Items.Add("Baleno");
                Modelcombo.Items.Add("Swift");
                Modelcombo.Items.Add("SX4");
                Modelcombo.Items.Add("Liana");
                Modelcombo.Items.Add("Maruti");

            }
            else if (Markacombo.SelectedIndex == 33)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Model 3");
                Modelcombo.Items.Add("Model S");
                Modelcombo.Items.Add("Model X");
                Modelcombo.Items.Add("Model Y");

            }
            else if (Markacombo.SelectedIndex == 34)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("T10X");

            }
            else if (Markacombo.SelectedIndex == 35)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Auris");
                Modelcombo.Items.Add("Avensis");
                Modelcombo.Items.Add("Camry");
                Modelcombo.Items.Add("Carina");
                Modelcombo.Items.Add("Corolla");
                Modelcombo.Items.Add("Corona");
                Modelcombo.Items.Add("Cressida");
                Modelcombo.Items.Add("GT86");
                Modelcombo.Items.Add("Mark 2");
                Modelcombo.Items.Add("MR2");
                Modelcombo.Items.Add("Prius");
                Modelcombo.Items.Add("Supra");

            }
            else if (Markacombo.SelectedIndex == 36)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("Arteon");
                Modelcombo.Items.Add("Beetle");
                Modelcombo.Items.Add("Bora");
                Modelcombo.Items.Add("EOS");
                Modelcombo.Items.Add("Golf");
                Modelcombo.Items.Add("ID.3");
                Modelcombo.Items.Add("Jetta");
                Modelcombo.Items.Add("Lupo");
                Modelcombo.Items.Add("Passat");
                Modelcombo.Items.Add("Passat Alltrack");
                Modelcombo.Items.Add("Passat Variant");
                Modelcombo.Items.Add("Phaeton");
                Modelcombo.Items.Add("Polo");
                Modelcombo.Items.Add("Santana");
                Modelcombo.Items.Add("Scirocco");
                Modelcombo.Items.Add("Sharan");
                Modelcombo.Items.Add("Touran");
                Modelcombo.Items.Add("Up Club");
                Modelcombo.Items.Add("VW CC");
                Modelcombo.Items.Add("Vento");

            }
            else if (Markacombo.SelectedIndex == 37)
            {

                Modelcombo.Items.Clear();
                Modelcombo.Text = string.Empty;

                Modelcombo.Items.Add("C30");
                Modelcombo.Items.Add("C70");
                Modelcombo.Items.Add("S40");
                Modelcombo.Items.Add("S60");
                Modelcombo.Items.Add("S70");
                Modelcombo.Items.Add("S80");
                Modelcombo.Items.Add("S90");
                Modelcombo.Items.Add("V40");
                Modelcombo.Items.Add("V40 Cross Country");
                Modelcombo.Items.Add("V50");
                Modelcombo.Items.Add("V60");
                Modelcombo.Items.Add("V60 Cross Country");
                Modelcombo.Items.Add("V70");
                Modelcombo.Items.Add("V90 Cross Country");

            }

        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            Durumcombo.SelectedIndex = 0;
        }

        private void AracEklebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Plakatext.Text) ||
                string.IsNullOrEmpty(Markacombo.Text) ||
                string.IsNullOrEmpty(Modelcombo.Text) ||
                string.IsNullOrEmpty(ModelYilicombo.Text) ||
                string.IsNullOrEmpty(Renkcombo.Text) ||
                string.IsNullOrEmpty(Kilometretext.Text) ||
                string.IsNullOrEmpty(Yakitcombo.Text) ||
                string.IsNullOrEmpty(KiraUcretitext.Text) ||
                string.IsNullOrEmpty(Durumcombo.Text) ||
                string.IsNullOrEmpty(Sehircombo.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!");
            }
            else
            {
                string input = Plakatext.Text;

                if (input.Length >= 2)
                {
                    string firstTwoChars = input.Substring(0, 2);

                    if (!Regex.IsMatch(firstTwoChars, "^[0-9]+$"))
                    {
                        MessageBox.Show("Plaka Kodunu Düzgün Giriniz!");
                        Plakatext.Focus();
                        return;
                    }
                }

                string plaka = Plakatext.Text.ToUpper();
                string komutCumlesi = "SELECT Plaka FROM Araclar WHERE Plaka=@Plaka";
                using (SqlConnection baglanti = new SqlConnection(bgl.ADRES))
                
                {
                    using (SqlCommand komut = new SqlCommand(komutCumlesi, baglanti))
                    {
                        baglanti.Open();
                        komut.Parameters.AddWithValue("@Plaka", plaka);
                        using (SqlDataReader reader = komut.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Bu Plakaya Sahip Bir Araç Zaten Var!");
                                return;
                            }
                            else
                            {
                                int ucret;
                                int kilometre;
                                if (int.TryParse(Kilometretext.Text, out kilometre) && kilometre < 0)
                                {
                                    MessageBox.Show("Aracın Kilometresi Pozitif Bir Sayı Olmalı!");
                                    return;
                                }
                                else if (int.TryParse(KiraUcretitext.Text, out ucret) && ucret < 0)
                                {
                                    MessageBox.Show("Aracın Kira Ücreti Pozitif Bir Sayı Olmalı!");
                                    return;

                                }
                            }
                        }
                    }
                    string komutCumlesi2 = "INSERT INTO Araclar (Plaka, Marka, Model, Model_Yili, Renk, Kilometre, Yakit, Kira_Ucreti, Durum, Bulundugu_Sehir) VALUES (@Plaka, @Marka, @Model, @Model_Yili, @Renk, @Kilometre, @Yakit, @Kira_Ucreti, @Durum, @Bulundugu_Sehir)";
                    using (SqlCommand komut2 = new SqlCommand(komutCumlesi2, baglanti))
                    {
                        komut2.Parameters.AddWithValue("@Plaka", plaka);
                        komut2.Parameters.AddWithValue("@Marka", Markacombo.Text);
                        komut2.Parameters.AddWithValue("@Model", Modelcombo.Text);
                        komut2.Parameters.AddWithValue("@Model_Yili", ModelYilicombo.Text);
                        komut2.Parameters.AddWithValue("@Renk", Renkcombo.Text);
                        komut2.Parameters.AddWithValue("@Kilometre", Kilometretext.Text);
                        komut2.Parameters.AddWithValue("@Yakit", Yakitcombo.Text);
                        komut2.Parameters.AddWithValue("@Kira_Ucreti", KiraUcretitext.Text);
                        komut2.Parameters.AddWithValue("@Durum", Durumcombo.Text);
                        komut2.Parameters.AddWithValue("@Bulundugu_Sehir", Sehircombo.Text);

                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Araç Başarılı Bir Şekilde Eklendi!");

                        Plakatext.Clear();
                        Markacombo.Text = " ";
                        Modelcombo.Text = " ";
                        ModelYilicombo.Text = " ";
                        Renkcombo.Text = " ";
                        Kilometretext.Clear();
                        Yakitcombo.Text = " ";
                        KiraUcretitext.Clear();
                        Sehircombo.Text = " ";
                    }
                }
            }
        }

        private void Kilometretext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KiraUcretitext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Plakatext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
