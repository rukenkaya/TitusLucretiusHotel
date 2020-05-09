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
    public partial class FrmPasswordUpdate : Form
    {
        public FrmPasswordUpdate()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6UGHI29;Initial Catalog=TitusLucretiusHotel;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + txtKullaniciAd.Text + "', Sifre='" + txtSifre.Text + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifre güncelleme işlemi başarılı.");
           
        }
    }
}
