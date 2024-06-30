using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği sayıyı al
            if (int.TryParse(textBox1.Text, out int sayi1))
            {
                // Armstrong sayısı kontrolü
                bool ArmstrongsayiMi = Armstrongsayi(sayi1);

                // Sonuçları Listbox'a ekle
                listBox1.Items.Add($"Sayı: {sayi1}, Armstrong: {(ArmstrongsayiMi ? "Evet" : "Hayır")}");
            }
            else
            {
                MessageBox.Show("Geçerli bir sayı giriniz.");
            }
        }

        // Bir sayının Armstrong sayısı olup olmadığını kontrol eden metot
        private bool Armstrongsayi(int sayi1)
        {
            int sayi2 = sayi1;
            int digitCount = (int)Math.Floor(Math.Log10(sayi1) + 1);
            int sonuc = 0;

            while (sayi1 > 0)
            {
                int digit = sayi1 % 10;
                sonuc += (int)Math.Pow(digit, digitCount);
                sayi1 /= 10;
            }

            return sonuc == sayi2;
        }
    }
}
