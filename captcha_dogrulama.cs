using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha
{
    public partial class Form1 : Form
    {
        string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
        string[] sembol2 = { "A", "B", "C", "D", "E", "F", "G" };
        string[] sembol4 = { "+", "-", "/", "*", "#", "%", "$" };
        int s1, s2, s3, s4, s5;
        public Form1()
        {
            InitializeComponent();


            Random rnd = new Random();

            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, 10);
            s4 = rnd.Next(0, sembol4.Length);
            s5 = rnd.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3 + sembol4[s4].ToString() + s5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(textBox1.Text == label1.Text)
            {
                MessageBox.Show("Giriş Yapıldı.","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 fr = new Form2();
                fr.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış değerler, tekrar deneyin.","Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Random rnd2 = new Random();
                s1 = rnd2.Next(0, sembol1.Length);
                s2 = rnd2.Next(0, sembol2.Length);
                s3 = rnd2.Next(0, 10);
                s4 = rnd2.Next(0, sembol4.Length);
                s5 = rnd2.Next(0, 10);

                label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3 + sembol4[s4].ToString() + s5;

            }
        }
    }
}
