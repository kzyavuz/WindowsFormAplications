using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void hesaplabutton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double yariCap))
            {
                Daire daire1 = new Daire(yariCap);

                double alan = daire1.AlanHesapla();
                double cevre = daire1.CevreHesapla();

                alanLabel.Text = $"Dairenin Alanı: {alan:F2}";
                cevreLabel.Text = $"Dairenin Çevresi: {cevre:F2}";
            }
            else
            {
                MessageBox.Show("Geçerli bir yarıçap değeri girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Daire
    {
        private double yariCap;

        public Daire(double yariCap)
        {
            this.yariCap = yariCap;
        }

        public double AlanHesapla()
        {
            return Math.PI * Math.Pow(yariCap, 2);
        }

        public double CevreHesapla()
        {
            return 2 * Math.PI * yariCap;
        }
    }
}

