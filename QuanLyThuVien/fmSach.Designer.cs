
namespace QuanLyThuVien
{
    partial class fmSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_sua = new System.Windows.Forms.Button();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_nxb = new System.Windows.Forms.TextBox();
            this.txt_ts = new System.Windows.Forms.TextBox();
            this.txt_namxb = new System.Windows.Forms.TextBox();
            this.txt_ms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NhaXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(278, 121);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(74, 19);
            this.bt_sua.TabIndex = 4;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(315, 46);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(105, 20);
            this.txt_sl.TabIndex = 1;
            // 
            // txt_nxb
            // 
            this.txt_nxb.Location = new System.Drawing.Point(100, 72);
            this.txt_nxb.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nxb.Name = "txt_nxb";
            this.txt_nxb.Size = new System.Drawing.Size(105, 20);
            this.txt_nxb.TabIndex = 1;
            // 
            // txt_ts
            // 
            this.txt_ts.Location = new System.Drawing.Point(100, 46);
            this.txt_ts.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ts.Name = "txt_ts";
            this.txt_ts.Size = new System.Drawing.Size(105, 20);
            this.txt_ts.TabIndex = 1;
            // 
            // txt_namxb
            // 
            this.txt_namxb.Location = new System.Drawing.Point(315, 22);
            this.txt_namxb.Margin = new System.Windows.Forms.Padding(2);
            this.txt_namxb.Name = "txt_namxb";
            this.txt_namxb.Size = new System.Drawing.Size(105, 20);
            this.txt_namxb.TabIndex = 1;
            // 
            // txt_ms
            // 
            this.txt_ms.Location = new System.Drawing.Point(100, 22);
            this.txt_ms.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ms.Name = "txt_ms";
            this.txt_ms.Size = new System.Drawing.Size(105, 20);
            this.txt_ms.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà Xuất Bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Năm Xuất Bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách:";
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Location = new System.Drawing.Point(101, 121);
            this.bt_capnhat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(74, 19);
            this.bt_capnhat.TabIndex = 5;
            this.bt_capnhat.Text = "Cập Nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            // 
            // NamXB
            // 
            this.NamXB.Text = "Năm Xuất Bản";
            // 
            // NhaXB
            // 
            this.NhaXB.Text = "Nhà Xuất Bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách:";
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã Sách";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach,
            this.TenSach,
            this.NhaXB,
            this.NamXB,
            this.SoLuong});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 166);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên Sách";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(191, 121);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(74, 19);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xoá";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(520, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sl);
            this.groupBox1.Controls.Add(this.txt_nxb);
            this.groupBox1.Controls.Add(this.txt_ts);
            this.groupBox1.Controls.Add(this.txt_namxb);
            this.groupBox1.Controls.Add(this.txt_ms);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(445, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // fmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 352);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmSach";
            this.Text = "fmSach";
            this.Load += new System.EventHandler(this.fmSach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_nxb;
        private System.Windows.Forms.TextBox txt_ts;
        private System.Windows.Forms.TextBox txt_namxb;
        private System.Windows.Forms.TextBox txt_ms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader NamXB;
        private System.Windows.Forms.ColumnHeader NhaXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader MaSach;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}