
namespace Is_projesi.Formlar
{
    partial class Departmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departmanlar));
            this.DepartamentAdi = new DevExpress.XtraEditors.LabelControl();
            this.TxtiD = new DevExpress.XtraEditors.TextEdit();
            this.ListeleBt = new DevExpress.XtraEditors.SimpleButton();
            this.DepartamentID = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.SilBt = new DevExpress.XtraEditors.SimpleButton();
            this.GuncellemeBt = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ElaveEtBt = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.TxtiD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartamentAdi
            // 
            this.DepartamentAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartamentAdi.Appearance.Options.UseFont = true;
            this.DepartamentAdi.Location = new System.Drawing.Point(26, 117);
            this.DepartamentAdi.Name = "DepartamentAdi";
            this.DepartamentAdi.Size = new System.Drawing.Size(179, 24);
            this.DepartamentAdi.TabIndex = 5;
            this.DepartamentAdi.Text = "Departament Adi:";
            // 
            // TxtiD
            // 
            this.TxtiD.Location = new System.Drawing.Point(26, 80);
            this.TxtiD.Name = "TxtiD";
            this.TxtiD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtiD.Properties.Appearance.Options.UseFont = true;
            this.TxtiD.Properties.Mask.EditMask = "[0-7]+";
            this.TxtiD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtiD.Properties.ReadOnly = true;
            this.TxtiD.Size = new System.Drawing.Size(192, 32);
            this.TxtiD.TabIndex = 6;
            // 
            // ListeleBt
            // 
            this.ListeleBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeleBt.Appearance.Options.UseFont = true;
            this.ListeleBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListeleBt.ImageOptions.Image")));
            this.ListeleBt.Location = new System.Drawing.Point(26, 180);
            this.ListeleBt.Name = "ListeleBt";
            this.ListeleBt.Size = new System.Drawing.Size(197, 48);
            this.ListeleBt.TabIndex = 7;
            this.ListeleBt.Text = " Listele";
            this.ListeleBt.Click += new System.EventHandler(this.Listele_Click_1);
            // 
            // DepartamentID
            // 
            this.DepartamentID.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartamentID.Appearance.Options.UseFont = true;
            this.DepartamentID.Location = new System.Drawing.Point(34, 50);
            this.DepartamentID.Name = "DepartamentID";
            this.DepartamentID.Size = new System.Drawing.Size(171, 24);
            this.DepartamentID.TabIndex = 8;
            this.DepartamentID.Text = "Departament ID:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(26, 144);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Properties.Mask.EditMask = "[a-z A-Z]+";
            this.TxtAd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TxtAd.Size = new System.Drawing.Size(197, 30);
            this.TxtAd.TabIndex = 9;
            
            // SilBt
            // 
            this.SilBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilBt.Appearance.Options.UseFont = true;
            this.SilBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SilBt.ImageOptions.Image")));
            this.SilBt.Location = new System.Drawing.Point(26, 294);
            this.SilBt.Name = "SilBt";
            this.SilBt.Size = new System.Drawing.Size(197, 54);
            this.SilBt.TabIndex = 11;
            this.SilBt.Text = "Sil";
            this.SilBt.Click += new System.EventHandler(this.SilBt_Click);
            // 
            // GuncellemeBt
            // 
            this.GuncellemeBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuncellemeBt.Appearance.Options.UseFont = true;
            this.GuncellemeBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GuncellemeBt.ImageOptions.Image")));
            this.GuncellemeBt.Location = new System.Drawing.Point(26, 358);
            this.GuncellemeBt.Name = "GuncellemeBt";
            this.GuncellemeBt.Size = new System.Drawing.Size(197, 54);
            this.GuncellemeBt.TabIndex = 12;
            this.GuncellemeBt.Text = "Guncelle";
            this.GuncellemeBt.Click += new System.EventHandler(this.GuncellemeBt_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ElaveEtBt);
            this.groupControl1.Controls.Add(this.DepartamentID);
            this.groupControl1.Controls.Add(this.GuncellemeBt);
            this.groupControl1.Controls.Add(this.DepartamentAdi);
            this.groupControl1.Controls.Add(this.SilBt);
            this.groupControl1.Controls.Add(this.ListeleBt);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.TxtiD);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 560);
            this.groupControl1.TabIndex = 13;
            // 
            // ElaveEtBt
            // 
            this.ElaveEtBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElaveEtBt.Appearance.Options.UseFont = true;
            this.ElaveEtBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ElaveEtBt.ImageOptions.Image")));
            this.ElaveEtBt.Location = new System.Drawing.Point(26, 234);
            this.ElaveEtBt.Name = "ElaveEtBt";
            this.ElaveEtBt.Size = new System.Drawing.Size(197, 54);
            this.ElaveEtBt.TabIndex = 13;
            this.ElaveEtBt.Text = "Elave Et";
            this.ElaveEtBt.Click += new System.EventHandler(this.ElaveEtBt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 560);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupControl1);
            this.panel3.Location = new System.Drawing.Point(804, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 560);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 557);
            this.panel2.TabIndex = 15;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(801, 557);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // Departmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 560);
            this.Controls.Add(this.panel1);
            this.Name = "Departmanlar";
            this.Text = "Departmanlar";
            ((System.ComponentModel.ISupportInitialize)(this.TxtiD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl DepartamentAdi;
        private DevExpress.XtraEditors.TextEdit TxtiD;
        private DevExpress.XtraEditors.SimpleButton ListeleBt;
        private DevExpress.XtraEditors.LabelControl DepartamentID;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.SimpleButton SilBt;
        private DevExpress.XtraEditors.SimpleButton GuncellemeBt;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton ElaveEtBt;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}