namespace DoAnWD
{
    partial class frmTK
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
            this.crvTK = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTK
            // 
            this.crvTK.ActiveViewIndex = -1;
            this.crvTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTK.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTK.Location = new System.Drawing.Point(0, 0);
            this.crvTK.Name = "crvTK";
            this.crvTK.Size = new System.Drawing.Size(800, 450);
            this.crvTK.TabIndex = 0;
            // 
            // frmTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvTK);
            this.Name = "frmTK";
            this.Text = "frmTK";
            this.Load += new System.EventHandler(this.frmTK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTK;
    }
}