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
    public partial class FrmNotlarOgrt : Form
    {
        public FrmNotlarOgrt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET;Initial Catalog=Okul_Proje;Integrated Security=True");

        public string ogrtid;
        string dersid1;
        private void FrmNotlarOgrt_Load(object sender, EventArgs e)
        {
            // this.Text = ogrtid;
            //notlar kısmında form textinde ders ismini yazdırıyoruz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select DersAd,Dersid From Tbl_Dersler INNER JOIN Tbl_Ogretmenler ON Tbl_Dersler.Dersid=Tbl_Ogretmenler.OgrtBrans Where OgrtBrans=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",ogrtid);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) {
                this.Text = dr[0].ToString();
                dersid1 = dr[1].ToString();
            }
            baglanti.Close();

            //datagride verileri çekelim
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Tbl_Notlar.Ogrid,OgrAd,OgrSoyad,Sinav1,Sinav2,Sinav3,Proje,Ortalama,Durum From Tbl_Notlar RIGHT JOIN Tbl_Ogrenciler ON Tbl_Notlar.Ogrid=Tbl_Ogrenciler.Ogrid where Dersid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1",ogrtid);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsinav1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsinav2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }
        //ortalama ve durum veri tabanında Stored Procedure ler ile yapılacak
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Update Tbl_Notlar Set Sinav1=@p1,Sinav2=@p2,Sinav3=@p3,Proje=@p4 Where Ogrid=@p5 And Dersid=@p6",baglanti);
            komut3.Parameters.AddWithValue("@p1",txtsinav1.Text);
            komut3.Parameters.AddWithValue("@p2",txtsinav2.Text);
            komut3.Parameters.AddWithValue("@p3",txtSinav3.Text);
            komut3.Parameters.AddWithValue("@p4",txtProje.Text);
            komut3.Parameters.AddWithValue("@p5",txtid.Text);
            komut3.Parameters.AddWithValue("@p6",dersid1);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Başarılı");
        }
    }
}
