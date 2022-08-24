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
    public partial class fmDocGia : Form
    {
        public fmDocGia()
        {
            InitializeComponent();
        }
        QLTVEntities db = new QLTVEntities();
        void load_dl()
        {
            listView1.Items.Clear();
            foreach (tblDocGia s in db.tblDocGias.ToList())
            {
                ListViewItem item = new ListViewItem(s.MaDocgia);
                item.SubItems.Add(s.TenDocgia);
                item.SubItems.Add(s.Coquan);
                item.SubItems.Add(s.Điachi);
                item.SubItems.Add(s.Tel.ToString());
                listView1.Items.Add(item);
            }
        }
        private void fmDocGia_Load(object sender, EventArgs e)
        {
            load_dl();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                tblDocGia d = new tblDocGia();//tạo đọc giả mới
                d.MaDocgia = txt_dg.Text;
                d.TenDocgia = txt_hoten.Text;
                d.Coquan = txt_cq.Text;
                d.Điachi = txt_dc.Text;
                d.Tel = txt_sdt.Text;
                db.tblDocGias.Add(d);
                db.SaveChanges();
                load_dl();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật lỗi, kiểm tra lại dữ liệu trên form");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; 1 > 0; i--)
            {
                // lây hàng thư i chọn trên lưới                   
                String madocgia = listView1.SelectedItems[i].SubItems[0].Text.ToString();
                tblDocGia d = db.tblDocGias.Where(s => s.MaDocgia.Contains(madocgia)).FirstOrDefault();
                db.tblDocGias.Remove(d);
                db.SaveChanges();
            }
            load_dl();
        }

        

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                tblDocGia d = db.tblDocGias.Find(txt_dg.Text);//lấy độc giả theo mã               
                d.TenDocgia = txt_dg.Text;
                d.Coquan = txt_cq.Text;
                d.Điachi = txt_dc.Text;
                d.Tel = txt_sdt.Text;
                db.SaveChanges();
                load_dl();
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa lỗi, kiểm tra lại dữ liệu nhập trên form");
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txt_dg.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                txt_hoten.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                txt_cq.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                txt_dc.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
                txt_sdt.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            try
            {
                tblDocGia d = db.tblDocGias.Where(s => s.MaDocgia.Contains(txt_dg.Text) && s.TenDocgia.Contains(txt_hoten.Text)).FirstOrDefault();
                txt_dc.Text = d.Điachi;
                txt_cq.Text = d.Coquan;
                txt_sdt.Text = d.Tel;


            }
            catch (Exception)
            {

                MessageBox.Show("Không tìm thấy!");
            }


        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            fmIndg a = new fmIndg();
            a.Show();
        }
    }
}
