using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitusLucretiusHotel
{
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            frm.Show();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frm = new FrmNewCustomer();
            frm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmCustomers frm = new FrmCustomers();
            frm.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmRooms frm = new FrmRooms();
            frm.Show();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            FrmStocks frm = new FrmStocks();
            frm.Show();
        }
        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FrmRevenueExpense frm = new FrmRevenueExpense();
            frm.Show();
        }

        private void btnMusteriMesajlari_Click(object sender, EventArgs e)
        {
            FrmMessages frm = new FrmMessages();
            frm.Show();
        }

        private void btnRadyoDinle_Click(object sender, EventArgs e)
        {
            FrmListenToRadio frm = new FrmListenToRadio();
            frm.Show();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titus Lucretius Hotel / 2020 - İSTANBUL");
        }

        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text  = DateTime.Now.ToLongTimeString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGazete_Click(object sender, EventArgs e)
        {
            FrmNewspaper frm = new FrmNewspaper();
            frm.Show();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FrmPasswordUpdate frm = new FrmPasswordUpdate();
            frm.Show();
        }

    }
}
