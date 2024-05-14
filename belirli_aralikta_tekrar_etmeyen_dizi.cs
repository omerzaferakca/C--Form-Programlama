using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilari5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!=""&&textBox3.Text!="")
            {
                int adet, sayi1, sayi2;

                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                adet = Convert.ToInt32(textBox3.Text);
                int[] dizi = new int[adet];
                Random rnd = new Random();
                
                if(sayi1<sayi2)
                {
                    listBox1.Items.Clear();
                    int varmi = 0;
                    
                    if(sayi2-sayi1>adet)
                    {
                        for (int i = 0; i < adet; i++)
                        {
                            int r_sayi = rnd.Next(sayi1 + 1, sayi2);

                            for (int j = 0; j < i; j++)
                            {
                                if (dizi[j] == r_sayi)
                                {
                                    varmi = 1;
                                }
                            }
                            if (varmi == 0)
                            {
                                dizi[i] = r_sayi;
                                listBox1.Items.Add(dizi[i]);
                            }
                            else
                            {
                                i--;
                                varmi = 0;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("İstenilen sayı adedi aralıktan fazla olamaz");
                    }   
                }
                
                if(sayi2<sayi1)
                {
                    listBox1.Items.Clear();
                }
                

            }
            else
            {
                MessageBox.Show("Lütfen değerleri giriniz.");
            }
        }
    }
}
