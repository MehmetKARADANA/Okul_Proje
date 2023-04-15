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
    public partial class FrmKulupler : Form
    {
        public FrmKulupler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET;Initial Catalog=Okul_Proje;Integrated Security=True");

        private void FrmKulupler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Ogrid,OgrAd,OgrSoyad,OgrKulup,KulupAd,Kulupid From Tbl_Ogrenciler Left Join Tbl_Kulup ON Tbl_Ogrenciler.OgrKulup=Tbl_Kulup.Kulupid", baglanti);
            SqlDataAdapter da =new  SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Kulup", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglanti.Close();




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKulup.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtkulupid.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Ogrenciler Set OgrKulup=@p1 Where Ogrid=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1",txtkulupid.Text);
            komut.Parameters.AddWithValue("@p2",txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp güncellendi");
        }

       
    }
}
