using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplama,carpma, cikarma, bolme;

            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);

            toplama = sayi2 + sayi1;
            cikarma = sayi2 - sayi1;
            carpma = sayi2 * sayi1;
            bolme = sayi2 / sayi1;

            lblToplama.Text = "Toplama: " + toplama;
            lblCikarma.Text = "Çıkarma: " + cikarma;
            lblCarpma.Text = "Çarpma: " + carpma;
            lblBolme.Text = "Bölme: " + bolme;



        }
    }
}
