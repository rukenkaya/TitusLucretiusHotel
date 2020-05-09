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
    public partial class FrmStocks : Form
    {
        public FrmStocks()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6UGHI29;Initial Catalog=TitusLucretiusHotel;Integrated Security=True");

        private void StokVerileri()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void StokVerileri2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();

        }


        private void btnStokKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into Stoklar(Gida,Icecek,Cerezler) values('"+txtboxGıdaTutar.Text+"', '"+tboxIcecekTutar.Text+"', '"+txtboxCerez.Text+"')", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            StokVerileri();
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            StokVerileri();
            StokVerileri2();
        }

        private void btnStokKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("insert into Faturalar(Elektrik,Su,Internet) values('" + txtElektirk.Text + "', '" + txtSu.Text + "', '" + txtInternet.Text + "')", baglanti);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            StokVerileri2();
        }
    }
}
