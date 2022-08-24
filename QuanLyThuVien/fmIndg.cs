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
    public partial class fmIndg : Form
    {
        public fmIndg()
        {
            InitializeComponent();
        }
        QLTVEntities db = new QLTVEntities();
        private void fmIndg_Load(object sender, EventArgs e)
        {
            // tạo 1 report giống như repot mình thiết kế  
            CrystalReport1 rpt = new CrystalReport1();
            // gán dữ liệu cho rpt
            rpt.SetDataSource(db.tblDocGias.ToList());
            viewDG.ReportSource = rpt;
        }
    }
}
