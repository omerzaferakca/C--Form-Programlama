using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapilari7
{

    public partial class Form1 : Form
    {
        int sayi1, sayi2, deger, adet;
        int[] dizi;
        int[] dizi2;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public int fnk_kucuk(int[] dizi)
        {
            int kucuk_deger = dizi[0];

            for(int j = 0;j<dizi.Length;j++)
            {
                if (kucuk_deger > dizi[j])
                {
                    kucuk_deger = dizi[j];
                }
            }

            return kucuk_deger;

        }


        public int fnk_tekrar(int[] dizi,int s1)
        {
            int t_deger = s1;
            int sayac = 0;

            for (int i = 0; i<dizi.Length; i++)
            {
                if (dizi[i] == t_deger)
                {
                    sayac++;
                }
            }

            return sayac;

        }

        private void fnk_mesaj(string a)
        {
            MessageBox.Show(a);
        }

        private void fnk_sirala(int[] dizi)
        {
            int ref_deger = dizi[0];

            for(int i=0;i<dizi.Length;i++)
            {
                for(int j=i;j<dizi.Length; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        ref_deger = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = ref_deger;
                    }
                }
            }

            for(int k=0; k<dizi.Length; k++)
            {
                listBox2.Items.Add(dizi[k]);
            }

        }

        public int fnk_kiyas(int[] dizi,int[] dizi2)
        {
            int en_buyuk = dizi[0];


            for(int i=0;i<dizi.Length;i++)
            {
                if (en_buyuk < dizi[i])
                {
                    en_buyuk = dizi[i];
                }
            }
            for( int k=0;k<dizi2.Length;k++)
            {
                if (en_buyuk < dizi2[k])
                {
                    en_buyuk = dizi2[k];
                }
            }

            return en_buyuk;
        }

        private void fnk_sirala2(int[] dizi, int[] dizi2)
        {
            //İki diziyi birleştirip sıralayan algoritma
            listBox2.Items.Clear();

            int[] dizi3 = new int[adet + adet];
            int k = 0, ref_deger = dizi3[0];

            for (int i=0;i<dizi.Length;i++)
            {
                dizi3[i] = dizi[i];
            }
            for(int j=dizi.Length;j<dizi2.Length+dizi.Length;j++)
            {
                dizi3[j]= dizi2[k];
                k++;
            }

            
           /*
            for(int l=0;l<dizi3.Length;l++)
            {
                for(int m =l;m<dizi3.Length;m++)
                {                     
                    if (dizi3[l] < dizi3[m])
                    {
                        ref_deger = dizi3[l];
                        dizi3[l] = dizi3[m];
                        dizi3[m] = ref_deger;

                    }
                }
            */
            
            for(int l =0; l<dizi3.Length;l++)
            {
                for(int m =l+1; m<dizi3.Length;m++)
                {

                    if (dizi3[l] > dizi3[m])
                    {
                        ref_deger = dizi3[l];
                        dizi3[l] = dizi3[m];
                        dizi3[m] = ref_deger;
                    }
                    
                }
                
            }

            for (int t = 0; t < dizi3.Length; t++)
            {
                listBox2.Items.Add(dizi3[t]);
            }


        }
        
        public bool fnk_lineer(int[] dizi, int a)
        {
            bool varMi = false;
            for(int i = 0;i<dizi.Length;i++)
            {
                if(a == dizi[i])
                {
                    varMi = true;
                }
            }
            return varMi;
        }
        

        private void fnk_ters(int[] dizi)
        {
            int deger = dizi[0];

            for (int i = 0; i < dizi.Length;)
            {
                    for (int j = dizi.Length-1; j >= i; j--)
                    {
                        deger = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = deger;
                        i++;
                    }
                i=dizi.Length;
            }

            for (int k = 0; k<dizi.Length; k++)
            {
                listBox2.Items.Add(dizi[k]);
            }
        }

        private void fnk_asal(int[] dizi,int s1,int s2)
        {
            if (s1 < s2)
            {
                listBox3.Items.Clear();
                int asal = 0;
                int varMi = 0;

                for (int i = 0; i < adet; i++)
                {
                    int r_sayi = rnd.Next(s1 + 1, s2);

                    for (int k = 0; k < dizi.Length; k++)
                    {
                        for (int j = 2; j < r_sayi; j++)
                        {
                            if (r_sayi % j == 0)
                            {
                                asal = 1;
                            }
                        }
                        if (r_sayi == dizi[k])
                        {
                            varMi = 1;
                        }

                    }
                    if (asal == 0 && varMi == 0)
                    {
                        dizi[i] = r_sayi;
                        listBox3.Items.Add(dizi[i]);
                    }
                    else
                    {
                        asal = 0;
                        varMi = 0;
                        i--;
                    }

                }
            }
            if (s2 < s1)
            {
                listBox3.Items.Clear();
                int asal = 0;
                int varMi = 0;
                for (int i = 0; i < dizi.Length; i++)
                {
                    int r_sayi = rnd.Next(s2 + 1, s1);

                    for(int k = 0;k<dizi.Length;k++)
                    {
                        for (int j = 2; j < r_sayi; j++)
                        {
                            if (r_sayi % j == 0)
                            {
                                asal = 1;
                            }
                        }
                        if(r_sayi == dizi[k])
                        {
                            varMi = 1;
                        }
                    }
                    if (asal == 0 && varMi==0)
                    {
                        dizi[i] = r_sayi;
                        listBox3.Items.Add(dizi[i]);
                    }
                    else
                    {
                        varMi = 0;
                        asal = 0;
                        i--;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            fnk_ters(dizi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                adet = Convert.ToInt32(textBox3.Text);
                dizi2 = new int[adet];

                fnk_asal(dizi2,sayi1, sayi2);


            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fnk_mesaj(Convert.ToString(fnk_kiyas(dizi, dizi2)));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

            fnk_sirala2(dizi,dizi2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int t_deger = Convert.ToInt32(textBox5.Text);
            fnk_mesaj(Convert.ToString(fnk_tekrar(dizi,t_deger)));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayi3 = Convert.ToInt32(textBox1.Text);
            int sayi4 = Convert.ToInt32(textBox2.Text);
            int adet = Convert.ToInt32(textBox3.Text);
            int[] dizi4 = new int[adet];
            int[] dizi5 = new int[adet];

            Random rnd = new Random();

            
            for(int i = 0;i<adet;i++)
            {
                dizi4[i]=rnd.Next(sayi3+1,sayi4);
                dizi5[i]=rnd.Next(sayi3+1,sayi4);
                listBox1.Items.Add(dizi4[i]);
                listBox2.Items.Add(dizi5[i]);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!="")
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                adet = Convert.ToInt32(textBox3.Text);
                dizi = new int[adet];
                Random rnd = new Random();

                if(sayi1<sayi2)
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < adet; i++)
                    {
                        dizi[i] = rnd.Next(sayi1+1,sayi2);
                        listBox1.Items.Add(dizi[i]);
                    }
                    //fnk_mesaj(Convert.ToString(fnk_kucuk(dizi)));
                }
                else if(sayi2 <sayi1) 
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < adet; i++)
                    {
                        dizi[i] = rnd.Next(sayi2+1,sayi1);
                        listBox1.Items.Add(dizi[i]);
                    }
                    //fnk_mesaj(Convert.ToString(fnk_kucuk(dizi)));
                }
                
            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger = Convert.ToInt32(textBox4.Text);
            fnk_mesaj(Convert.ToString(fnk_lineer(dizi, deger)));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            fnk_sirala(dizi);
        }
    }
}
