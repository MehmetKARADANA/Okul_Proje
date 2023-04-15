using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Proje
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        public string ogrtid1;
        private void txtDersler_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
        }

        private void btnOgretmenler_Click(object sender, EventArgs e)
        {
            FrmOgretmenlist fr = new FrmOgretmenlist();
            fr.Show();
        }

        private void btnKulupler_Click(object sender, EventArgs e)
        {
            FrmKulupler fr = new FrmKulupler();
            fr.Show();
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            FrmNotlarOgrt fr = new FrmNotlarOgrt();
            fr.ogrtid = ogrtid1;
            fr.Show();
        }
    }
}
