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
    public partial class FrmOgretmenlist : Form
    {
        public FrmOgretmenlist()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET;Initial Catalog=Okul_Proje;Integrated Security=True");

        private void FrmOgretmenlist_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut= new SqlCommand("Select OgrtAdSoyad AS 'Ad Soyad',DersAd AS 'Brans' From Tbl_Ogretmenler RIGHT JOIN Tbl_Dersler ON Tbl_Ogretmenler.OgrtBrans=Tbl_Dersler.Dersid ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
