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

namespace Okul_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET;Initial Catalog=Okul_Proje;Integrated Security=True");
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogretmenler Where Ogrtid=@p1 And OgrtAdSoyad=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",txtOgrtid.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrtAdSoyad.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmen fr = new FrmOgretmen();
                fr.Text = txtOgrtAdSoyad.Text;
                fr.ogrtid1 = txtOgrtid.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı ID & Ad Soyad");
            }
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenciler Where Ogrid=@p1 AND OgrAd=@p2 AND OgrSoyad=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
            komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenciNotlar fr = new FrmOgrenciNotlar();
                fr.numara = txtOgrid.Text;
                fr.Show();
            }
            else { MessageBox.Show("Hatalı Giriş"); }
           
            baglanti.Close();
           
        }
    }
}
