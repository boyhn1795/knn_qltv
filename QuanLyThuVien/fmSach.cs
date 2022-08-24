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
    public partial class fmSach : Form
    {
        public fmSach()
        {
            InitializeComponent();
        }
        QLTVEntities db = new QLTVEntities();
        void load_dl()
        {
            listView1.Items.Clear();
            foreach (tblSach s in db.tblSaches.ToList())
            {
                ListViewItem item = new ListViewItem(s.MaSach);
                item.SubItems.Add(s.TenSach);
                item.SubItems.Add(s.NhaXB);
                item.SubItems.Add(s.NamXB);
                item.SubItems.Add(s.SoLuong.ToString());
                listView1.Items.Add(item);
            }
        }
        void vohieuhoa(Boolean gt)
        {
            txt_ms.Enabled = gt;
            txt_ts.Enabled = gt;
            txt_nxb.Enabled = gt;
            txt_namxb.Enabled = gt;
            txt_sl.Enabled = gt;
            bt_sua.Enabled = gt;
            bt_xoa.Enabled = gt;
        }
        private void fmSach_Load(object sender, EventArgs e)
        {
            load_dl();
            vohieuhoa(false);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vohieuhoa(true);
            if (listView1.SelectedItems.Count > 0)
            {
                txt_ms.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                txt_ts.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                txt_nxb.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
                txt_namxb.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
                txt_sl.Text = listView1.SelectedItems[0].SubItems[4].Text.ToString();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i > 0; i--)
            {
                string MaSach = listView1.SelectedItems[i].SubItems[0].Text.ToString();
                listView1.SelectedItems[i].SubItems[0].Text.ToString();
                tblSach mh = db.tblSaches.Find(txt_ms.Text);
                db.tblSaches.Remove(mh);
                db.SaveChanges();

            }
            load_dl();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (bt_sua.Text == "Sửa")
                {
                    bt_sua.Text = "Lưu";
                    vohieuhoa(true);
                    txt_ms.Enabled = false;
                }
                else
                {
                    bt_sua.Text = "Sửa";
                    vohieuhoa(false);
                    //cập nhật csdl
                    tblSach s = db.tblSaches.Find(txt_ms.Text);//tìm sách theo mã                   
                    s.TenSach = txt_sl.Text;
                    //s.TenTacgia = txt.Text;
                    s.NhaXB = txt_nxb.Text;
                    s.NamXB = txt_namxb.Text;
                    s.SoLuong = int.Parse(txt_sl.Text);
                    db.SaveChanges();//lưu sách
                    load_dl();//hiển thị listview
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa sách lỗi, kiểm tra lại dữ liệu");
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if(bt_capnhat.Text=="Cập Nhật")
            {
                bt_capnhat.Text = "Lưu";
                vohieuhoa(true);
            }    
            else
            {
                //try
                //{
                //    tblSach s = db.tblSaches.Find(txt_ms.Text);
                //    if (s != null)
                //    {
                //        MessageBox.Show("Trùng Mã Sách", "Thông Báo");
                //        txt_ms.Focus();
                //    }
                //    else
                //    {
                        tblSach a = new tblSach();
                        a.MaSach = txt_ms.Text;
                        a.TenSach = txt_ts.Text;
                        a.NhaXB = txt_nxb.Text;
                        a.NamXB = txt_namxb.Text;
                        a.SoLuong = int.Parse(txt_sl.Text);
                        db.tblSaches.Add(a);
                        db.SaveChanges();
                        bt_capnhat.Text = "Cập Nhật";
                        load_dl();
                        vohieuhoa(false);
                //    }
                //}
                //catch
                //{
                //    MessageBox.Show("Lỗi");
                //}
           }
        }       
        
    }
}
