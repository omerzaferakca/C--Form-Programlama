using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System;
using System.Windows.Forms;

namespace ayrik_Matematik
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void aramaYap(string aramaCumlesi)
        {
            string searchUrl = "https://www.google.com/search?q=" + Uri.EscapeDataString(aramaCumlesi);

            Process.Start(new ProcessStartInfo
            {
                FileName = searchUrl, UseShellExecute = true
            });

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string cumle = textBox1.Text;
                foreach (char c in cumle)
                {
                    if (c == '?')
                    {
                        string aramaCumlesi1 = textBox1.Text;
                        aramaYap(aramaCumlesi1);
                        break;
                    }
                    else if (c == '!')
                    {
                        MessageBox.Show("Bu bir önerme deðildir.");
                        break;

                    }
                    else if(c=='x' || c=='/' || c=='-' || c=='+' || c=='*' || c=='=')
                    {
                        MessageBox.Show("Bu bir önerme olabilir.");
                    }
                    else if (c =='.')
                    {
                        if (textBox1.Text == "2 çift sayýdýr.")
                        {
                            MessageBox.Show("Bu bir önermedir. 1.");
                            break;
                        }
                        else if (textBox1.Text == "At bir hayvan türüdür.")
                        {
                            MessageBox.Show("Bu bir önermedir. 1.");
                            break;
                        }
                        else if (textBox1.Text == "Telefon yenilebilir bir gýdadýr.")
                        {
                            MessageBox.Show("Bu bir önermedir. 0.");
                            break;
                        }
                        else if (textBox1.Text == "Çaðla hoca mükemmeldir.")
                        {
                            MessageBox.Show("Bu bir önermedir. 1");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Bu bir önerme olabilir.");
                            break;
                        }
                    }
                    

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir cümle giriniz.");
            }
            

        }
    }
}
