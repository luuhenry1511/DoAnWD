namespace DoAnWD
{
    partial class Thongkedt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongkedt));
            this.label1 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mời chọn thời gian thống kê";
            // 
            // cboThang
            // 
            this.cboThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(104, 78);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(114, 27);
            this.cboThang.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(168, 151);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(154, 46);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem thông tin";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbNam
            // 
            this.cbNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(326, 81);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 27);
            this.cbNam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm:";
            // 
            // Thongkedt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.label1);
            this.Name = "Thongkedt";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.Thongkedt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboThang;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}