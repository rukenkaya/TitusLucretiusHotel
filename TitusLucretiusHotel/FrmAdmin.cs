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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6UGHI29;Initial Catalog=TitusLucretiusHotel;Integrated Security=True");
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", txtKullaniciAd.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);


                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmMainPage frm = new FrmMainPage();
                    frm.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız!");
            }  
             
        }
    }
}
