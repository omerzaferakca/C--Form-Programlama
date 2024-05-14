using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilari2
{
    public partial class Form1 : Form
    {
        int sayi;
        int puan;
        int toplamPuan;
        int adim;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            sayi = random.Next(100);
        }



        public void button2_Click(object sender, EventArgs e)
        {

            if(textBox4.Text!="")
            {

                adim++;
                textBox7.Text = Convert.ToString(adim);
                int girilenSayi = Convert.ToInt32(textBox4.Text);

                if(sayi<girilenSayi)
                {
                    MessageBox.Show("Daha küçük bir sayı giriniz.");
                }
                else if(sayi>girilenSayi)
                {
                    MessageBox.Show("Daha büyük bir sayı giriniz.");
                }
                else
                {
                    switch(adim)
                    {
                        case 1:
                            button2.Enabled = false;
                            puan = 1000;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                        case 2:
                            button2.Enabled = false;
                            puan = 250;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                        case 3:
                            button2.Enabled = false;
                            puan = 250;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                        case 4:
                            button2.Enabled = false;
                            puan = 250;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                        case 5:
                            button2.Enabled = false;
                            puan = 50;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                        case 6:
                            button2.Enabled = false;
                            puan = 50;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                        case 7:
                            button2.Enabled = false;
                            puan = 50;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                        default:
                            button2.Enabled = false;
                            puan = 10;
                            toplamPuan = toplamPuan + puan;
                            MessageBox.Show("Bildiniz!");
                            textBox5.Text = Convert.ToString(toplamPuan);
                            break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Tahmin et köle!");
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled=true;
            Random random2 = new Random();
            sayi = random2.Next(100);
            MessageBox.Show("Yeni bir sayı belirlendi.");
            adim = 0;

        }


    }
}
