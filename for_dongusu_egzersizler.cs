using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int sayi, sonuc = 1;

                sayi = Convert.ToInt32(textBox1.Text);

                for (int i = 1; i <= 10; i++)
                {
                    sonuc = i * sayi;
                    listBox1.Items.Add(sayi + " * " + i + " = " + sonuc);
                }

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text !="")
            {
                int sayi2, toplam = 0;
                listBox2.Items.Clear();
                sayi2 = Convert.ToInt32(textBox2.Text);
                for(int i = 1; i <= sayi2;i++)
                {
                    listBox2.Items.Add(2*i-1);
                    toplam += 2 * i - 1;

                }
                listBox2.Items.Add("Toplamları: " + toplam);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int sayi3;

            sayi3 = Convert.ToInt32(textBox3.Text);

            for(int i = 1;i <= sayi3;i++)
            {
                for(int j = 1; j <= i;j++)
                {
                    listBox3.Items.Add("*");
                }
                listBox3.Items.Add("\n");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int sayi4, k=1;

            sayi4 = Convert.ToInt32(textBox4.Text);

            for (int i = 1; i <= sayi4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    listBox4.Items.Add(k++);
                }
                listBox4.Items.Add("\n");
            }
        }
    }
}
