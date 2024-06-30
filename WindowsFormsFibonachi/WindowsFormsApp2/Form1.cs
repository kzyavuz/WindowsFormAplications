using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear(); // Önceki hesaplamayı temizle

            if (int.TryParse(textBox1.Text, out int n) && n >= 0 && n<=40)
            {
                for (int i = 0; i <= n; i++)
                {
                    listBox1.Items.Add($"fib({i}) = {Fibonacci(i)}");
                }
            }
            else
            {
                MessageBox.Show("Girilen sayı 0 ila 40 arasında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
