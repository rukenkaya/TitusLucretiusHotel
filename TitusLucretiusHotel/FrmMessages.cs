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
    public partial class FrmMessages : Form
    {
        public FrmMessages()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6UGHI29;Initial Catalog=TitusLucretiusHotel;Integrated Security=True");


        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MesajID"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
           
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void btnMesajKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(AdSoyad, Mesaj) values('"+txtAdSyd.Text+"', '"+richTxtMsg.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void FrmMessages_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        int id = 0;
        private void listView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdSyd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTxtMsg.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
      
    }
}
