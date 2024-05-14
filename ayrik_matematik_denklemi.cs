using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayrik_denklem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            n = Math.Abs(n);
            if (textBox1.Text!="")
            {
                for(int i = -n; i<=n;i++)
                {
                    int sayac = 0;
                    int sonuc = (9 * n * n) + (3 * n) - 3;
                    
                    if(sonuc % 2 == 0)
                    {
                        listBox1.Items.Add("Çift");
                    }
                    else
                    {                        
                        MessageBox.Show(sayac + ". sıradaki, " + i +". değerde tek sayıdır. İspat tamamlandı, yanlış.");
                        break;
                    }                
                }
                MessageBox.Show("Tespit doğrudur.");
            }
            else
            {
                MessageBox.Show("Lütfen girilen değeri kontrol ediniz.");
            }
        }


    }
}
