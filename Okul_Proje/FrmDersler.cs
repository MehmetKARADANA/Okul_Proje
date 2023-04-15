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
using System.Data.Common;

namespace Okul_Proje
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET;Initial Catalog=Okul_Proje;Integrated Security=True");


        private void FrmDersler_Load(object sender, EventArgs e)
        {//left join kullancam ki öğretmeni olmayan deslerde gelsin 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select DersAd AS 'Ders',OgrtAdSoyad AS 'Ad Soyad' From Tbl_Dersler LEFT JOIN Tbl_Ogretmenler ON Tbl_Dersler.Dersid=Tbl_Ogretmenler.OgrtBrans", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
