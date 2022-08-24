using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QLTVEntities db = new QLTVEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýĐộcGỉaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDocGia a = new fmDocGia();
            a.ShowDialog();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmSach a = new fmSach();
            a.ShowDialog();
        }
    }
}
