
namespace QuanLyThuVien
{
    partial class fmIndg
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
            this.viewDG = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // viewDG
            // 
            this.viewDG.ActiveViewIndex = -1;
            this.viewDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewDG.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewDG.Location = new System.Drawing.Point(0, 0);
            this.viewDG.Name = "viewDG";
            this.viewDG.Size = new System.Drawing.Size(800, 450);
            this.viewDG.TabIndex = 0;
            // 
            // fmIndg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewDG);
            this.Name = "fmIndg";
            this.Text = "fmIndg";
            this.Load += new System.EventHandler(this.fmIndg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewDG;
    }
}