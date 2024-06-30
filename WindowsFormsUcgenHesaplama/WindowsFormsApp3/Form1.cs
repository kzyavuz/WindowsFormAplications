using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            listBoxSonuclar.Items.Clear();
            if (radioButton1.Checked)
            {
                if (double.TryParse(textBox1.Text, out double kenar) && double.TryParse(textBox5.Text, out double yukseklik))

                {
                    double alan = AlanHesapla(kenar, yukseklik);
                    listBoxSonuclar.Items.Add($"Alan (a şıkkı): {alan}");
                }
                else
                {
                    MessageBox.Show("Geçersiz giriş! Lütfen sayısal değerleri doğru şekilde girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (radioButton2.Checked)
            {
                if (double.TryParse(textBox1.Text, out double kenar1) && double.TryParse(textBox2.Text, out double kenar2) && float.TryParse(textBox4.Text, out float aci))

                {
                    double alan = AlanHesapla(kenar1, kenar2, aci);
                    listBoxSonuclar.Items.Add($"Alan (b şıkkı): {alan}");
                }
                else
                {
                    MessageBox.Show("Geçersiz giriş! Lütfen sayısal değerleri doğru şekilde girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButton3.Checked) { 
                if (double.TryParse(textBox1.Text, out double kenar1c) && double.TryParse(textBox2.Text, out double kenar2c) && double.TryParse(textBox3.Text, out double kenar3))
                {
                    double alan = AlanHesapla(kenar1c, kenar2c, kenar3);
                    listBoxSonuclar.Items.Add($"Alan (c şıkkı): {alan}");
                }
                else
                {
                    MessageBox.Show("Geçersiz giriş! Lütfen sayısal değerleri doğru şekilde girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if(radioButton4.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }
        private double AlanHesapla(double kenar, double yukseklik)
        {
            return (kenar * yukseklik) / 2;
        }
        private double AlanHesapla(double kenar1, double kenar2, float aciDerece)
        {
            double aciRadyan = Math.PI * aciDerece / 180;
            return (kenar1 * kenar2 * Math.Sin(aciRadyan)) / 2;
        }
        private double AlanHesapla(double kenar1, double kenar2, double kenar3)
        {
            double u = (kenar1 + kenar2 + kenar3) / 2;
            return Math.Sqrt(u * (u - kenar1) * (u - kenar2) * (u - kenar3));
        }
    }
}
