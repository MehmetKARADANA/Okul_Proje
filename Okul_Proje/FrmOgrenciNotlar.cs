using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Okul_Proje
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET;Initial Catalog=Okul_Proje;Integrated Security=True");
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT DersAd,Sinav1,Sinav2,Sinav3,Proje,Ortalama,Durum FROM Tbl_Notlar INNER JOIN Tbl_Dersler ON Tbl_Notlar.Dersid=Tbl_Dersler.Dersid WHERE Ogrid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select OgrAd,OgrSoyad FROM Tbl_Ogrenciler Where Ogrid=@p1",baglanti);
            komut2.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read()) {
                this.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }
    }
}
