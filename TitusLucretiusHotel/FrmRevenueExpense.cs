using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TitusLucretiusHotel
{
    public partial class FrmRevenueExpense : Form
    {
        public FrmRevenueExpense()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6UGHI29;Initial Catalog=TitusLucretiusHotel;Integrated Security=True");

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Personel Maaşları
            int personelSayi;
            personelSayi = Convert.ToInt32(tboxPerSayisi.Text);
            lblPerMaas.Text = (personelSayi * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt32(lblPerMaas.Text)+ Convert.ToInt32(lblGıda.Text) + Convert.ToInt32(lblIcecek.Text) + Convert.ToInt32(lblCerez.Text)+ Convert.ToInt32(lblElektrik.Text)+ Convert.ToInt32(lblSu.Text)+ Convert.ToInt32(lblInternet.Text));
            lblTotalSonuc.Text = sonuc.ToString();

        }

        private void FrmRevenueExpense_Load(object sender, EventArgs e)
        {
            // Kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as Toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["Toplam"].ToString();
            }
            baglanti.Close();


            //STOKLARIN HESABI

            //Gida
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as Toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblGıda.Text = oku2["Toplam1"].ToString();
            }
            baglanti.Close();

            //Icecek
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Icecek) as Toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblIcecek.Text = oku3["Toplam2"].ToString();
            }
            baglanti.Close();

            //Çerez
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as Toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblCerez.Text = oku4["Toplam3"].ToString();
            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as Toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblElektrik.Text = oku5["Toplam4"].ToString();
            }
            baglanti.Close();


            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as Toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblSu.Text = oku6["Toplam5"].ToString();
            }
            baglanti.Close();


            // Internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as Toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblInternet.Text = oku7["Toplam6"].ToString();
            }
            baglanti.Close();


        }
    }
}
