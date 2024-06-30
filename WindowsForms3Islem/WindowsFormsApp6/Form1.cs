using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        private int sonuc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            sonuc = SayiKontrol(txt_number1.Text) + SayiKontrol(txt_number2.Text);
            label1.Text = "Toplam: " + Convert.ToString(sonuc);
        }

        private int SayiKontrol(string sayiText)
        {
            if (int.TryParse(sayiText, out int sayi))
            {
                return sayi;
            }
            else
            {
                MessageBox.Show("Girilen '" + sayiText + "' değer bir sayı değildir.");
                return 0;
            }
        }

        private void btn_çıkart_Click(object sender, EventArgs e)
        {
            sonuc = SayiKontrol(txt_number1.Text) - SayiKontrol(txt_number2.Text);
            label1.Text = "Kalan: "  + Convert.ToString(sonuc);
        }


        private void btn_carp_Click(object sender, EventArgs e)
        {
            sonuc = SayiKontrol(txt_number1.Text) * SayiKontrol(txt_number2.Text);
            label1.Text = "Çarpım: " + Convert.ToString(sonuc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
