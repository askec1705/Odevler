using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            string s1 = txtSayi1.Text;
            string s2 = txtSayi2.Text;

            int a;
            a = int.Parse(s1);
            int b;
            b = int.Parse(s2);
            // Parse yerine Convert'te kullanabilirsin

            int sonuç = (a + b) % (a - b);
            MessageBox.Show("İşlemin sonucu : " + sonuç);
              
        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            //1. yol
            int sayi = int.Parse(txtSayi1.Text);
            sayi = sayi - 10;
            sayi = sayi + 20;
            int mod = sayi % 2;
            sayi = mod * mod;
            MessageBox.Show("İşlem sonucu : " + sayi);
            //2. yol
            sayi = int.Parse(txtSayi1.Text);
            double sonuc = (sayi - 10 + 20) % 2;
            MessageBox.Show("İşlem sonucu : " + (sonuc * sonuc));
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = int.Parse(txtSayi2.Text);

            int birincikare = s1 * s1;
            int ikincikare = s2 * s2;

            int toplam = birincikare + ikincikare;
            int fark = birincikare - ikincikare;
            int sonuc = toplam + fark;

            MessageBox.Show("İşlem sonucu : " + sonuc);
        }

        private void BtnOrnek4_Click(object sender, EventArgs e)
        {
            double vize = double.Parse(txtSayi1.Text);
            double final = double.Parse(txtSayi2.Text);

            double sonuc = (vize * 0.30) + (final * 0.70);
            MessageBox.Show("Not ortalamanız : " + sonuc);
        }

        private void BtnOrnek5_Click(object sender, EventArgs e)
        {
            string isim = txtSayi1.Text;
            string soyisim = txtSayi2.Text;

            string mail = isim + "." + soyisim + "@hotmail.com";
            MessageBox.Show(mail);
        }
    }
}
