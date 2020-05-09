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
    public partial class FrmNewspaper : Form
    {
        public FrmNewspaper()
        {
            InitializeComponent();
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            WebBrowserNewspaper.Navigate("https://www.hurriyet.com.tr/");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            WebBrowserNewspaper.Navigate("https://www.milliyet.com.tr/");
        }

        private void btnSozcu_Click(object sender, EventArgs e)
        {
            WebBrowserNewspaper.Navigate("https://www.sozcu.com.tr/");
        }

        private void btnHaberturk_Click(object sender, EventArgs e)
        {
            WebBrowserNewspaper.Navigate("https://www.haberturk.com/");
        }

        private void btnPosta_Click(object sender, EventArgs e)
        {
            WebBrowserNewspaper.Navigate("https://www.posta.com.tr/");
        }

        private void btnKelebek_Click(object sender, EventArgs e)
        {
            WebBrowserNewspaper.Navigate("https://www.hurriyet.com.tr/haberleri/kelebek");
        }

        private void btnOnedio_Click(object sender, EventArgs e)
        {
            WebBrowserNewspaper.Navigate("https://onedio.com/");
        }

        
    }
}
