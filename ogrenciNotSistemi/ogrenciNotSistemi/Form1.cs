using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ogrenciNotSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ZAFER\\SQLEXPRESS;Initial Catalog=OgrenciNotSistemiVeriTabani;Integrated Security=True;Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;");
        
        private void temizle()
        {
            txt_No.Text = "";
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            cmb_DersAd.Text = "";
            msk_Vize.Text = "";
            msk_Final.Text = "";
            msk_Ortalama.Text = "";
            txt_Harf.Text = "";
            txt_Ad.Focus();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciNotSistemiVeriTabaniDataSet2.ogrenci_Not' table. You can move, or remove it, as needed.
            this.ogrenci_NotTableAdapter.Fill(this.ogrenciNotSistemiVeriTabaniDataSet2.ogrenci_Not);
            // TODO: This line of code loads data into the 'ogrenciNotSistemiVeriTabaniDataSet1.ogrenci_Not' table. You can move, or remove it, as needed.
            this.ogrenci_NotTableAdapter.Fill(this.ogrenciNotSistemiVeriTabaniDataSet2.ogrenci_Not);

        }
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            this.ogrenci_NotTableAdapter.Fill(this.ogrenciNotSistemiVeriTabaniDataSet2.ogrenci_Not);
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into ogrenci_Not (ogrenci_Ad,ogrenci_Soyad,ders_Adi,ders_Vize,ders_Final) values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1",txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3",cmb_DersAd.Text);
            komut.Parameters.AddWithValue("@p4", msk_Vize.Text);
            komut.Parameters.AddWithValue("@p5", msk_Final.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ögrenci Eklendi!");
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_No.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_DersAd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_Vize.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            msk_Final.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            msk_Ortalama.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt_Harf.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete From ogrenci_Not Where ogrenci_No=@k1",baglanti);
            komut.Parameters.AddWithValue("@k1",txt_No.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Silindi!");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("Update ogrenci_Not Set ogrenci_Ad=@a1,ogrenci_Soyad=@a2,ders_Adi=@a3,ders_Vize=@a4,ders_Final=@a5 where ogrenci_No=@a6",baglanti);

            komutGuncelle.Parameters.AddWithValue("@a1", txt_Ad.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", txt_Soyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", cmb_DersAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a4",msk_Vize.Text);
            komutGuncelle.Parameters.AddWithValue("@a5",msk_Final.Text);
            komutGuncelle.Parameters.AddWithValue("@a6", txt_No.Text);
            komutGuncelle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Öğrenci Kaydı Güncellendi!");
        }
    }
}
