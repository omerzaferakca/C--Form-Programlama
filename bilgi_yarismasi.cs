using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiYarismasi
{
    public partial class Form1 : Form
    {
        int dogru = 0, yanlis = 0, soruno = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text= btnA.Text;
            if (label4.Text ==label5.Text)
            {
                dogru++;
                lblDogru.Text = Convert.ToString(dogru);
            }
            else
            {
                yanlis++;
                lblYanlis.Text = Convert.ToString(yanlis);
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = Convert.ToString(dogru);
            }
            else
            {
                yanlis++;
                lblYanlis.Text = Convert.ToString(yanlis);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = Convert.ToString(dogru);
            }
            else
            {
                yanlis++;
                lblYanlis.Text = Convert.ToString(yanlis);
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = Convert.ToString(dogru);
            }
            else
            {
                yanlis++;
                lblYanlis.Text = Convert.ToString(yanlis);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled=true;
            btnB.Enabled=true;
            btnC.Enabled=true;
            btnD.Enabled=true;
            btnSonraki.Enabled=false;
            soruno++;
            lblSoruNo.Text = soruno.ToString();

            if(soruno==1)
            {
                richTextBox1.Text = "Benim adım ne?";
                btnA.Text = "Ömer";
                btnB.Text = "Zafer";
                btnC.Text = "Batman";
                btnD.Text = "John Cena";
                label4.Text = "Batman";
            }
            if(soruno==2)
            {
                richTextBox1.Text = "En sevdiğim şey ne?";
                btnA.Text = "Karım";
                btnB.Text = "Su";
                btnC.Text = "Yemek";
                btnD.Text = "Yaşamak";
                label4.Text = "Karım";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "En sevdiğim içecek ne?";
                btnA.Text = "Gazoz";
                btnB.Text = "Su";
                btnC.Text = "Kola";
                btnD.Text = "Çay";
                label4.Text = "Su";
                btnSonraki.Text = "Sonuçlar";
            }
            if(soruno==4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                if(dogru==3)
                {
                    MessageBox.Show("You know me.");
                }
                else
                {
                    MessageBox.Show("You don't know me!");
                }
            }
        }
    }
}
