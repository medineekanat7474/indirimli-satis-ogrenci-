using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirimli_satis_ogrenciindirimi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double adet, fiyat, odenecek;
            adet=Convert.ToDouble(txtAdet.Text);
            fiyat=Convert.ToDouble(txtFiyat.Text);
            
            if (chkogrenci.Checked)
            {
                odenecek = (adet * fiyat) * 0.8;
            }
            else
            {
                odenecek=adet*fiyat;
            }
            lblodenecek.Text="ödenecek tutar: "+odenecek.ToString();

        }
    }
}
