
namespace Is_projesi.Formlar
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            this.ID = new DevExpress.XtraEditors.LabelControl();
            this.GuncellemeBt = new DevExpress.XtraEditors.SimpleButton();
            this.Ad = new DevExpress.XtraEditors.LabelControl();
            this.SilBt = new DevExpress.XtraEditors.SimpleButton();
            this.ListeleBt = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtiD = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.TxtEmail = new DevExpress.XtraEditors.TextEdit();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.Departament = new DevExpress.XtraEditors.LabelControl();
            this.Telefon = new DevExpress.XtraEditors.LabelControl();
            this.Email = new DevExpress.XtraEditors.LabelControl();
            this.Soyad = new DevExpress.XtraEditors.LabelControl();
            this.ElaveEtBt = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtiD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Appearance.Options.UseFont = true;
            this.ID.Location = new System.Drawing.Point(157, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(36, 27);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID:";
            // 
            // GuncellemeBt
            // 
            this.GuncellemeBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuncellemeBt.Appearance.Options.UseFont = true;
            this.GuncellemeBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GuncellemeBt.ImageOptions.Image")));
            this.GuncellemeBt.Location = new System.Drawing.Point(157, 478);
            this.GuncellemeBt.Name = "GuncellemeBt";
            this.GuncellemeBt.Size = new System.Drawing.Size(260, 50);
            this.GuncellemeBt.TabIndex = 12;
            this.GuncellemeBt.Text = "Guncelle";
            this.GuncellemeBt.Click += new System.EventHandler(this.GuncellemeBt_Click);
            // 
            // Ad
            // 
            this.Ad.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ad.Appearance.Options.UseFont = true;
            this.Ad.Location = new System.Drawing.Point(143, 85);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(50, 27);
            this.Ad.TabIndex = 5;
            this.Ad.Text = " Adi:";
            // 
            // SilBt
            // 
            this.SilBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilBt.Appearance.Options.UseFont = true;
            this.SilBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SilBt.ImageOptions.Image")));
            this.SilBt.Location = new System.Drawing.Point(157, 433);
            this.SilBt.Name = "SilBt";
            this.SilBt.Size = new System.Drawing.Size(260, 50);
            this.SilBt.TabIndex = 11;
            this.SilBt.Text = "Sil";
            this.SilBt.Click += new System.EventHandler(this.SilBt_Click);
            // 
            // ListeleBt
            // 
            this.ListeleBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeleBt.Appearance.Options.UseFont = true;
            this.ListeleBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListeleBt.ImageOptions.Image")));
            this.ListeleBt.Location = new System.Drawing.Point(157, 354);
            this.ListeleBt.Name = "ListeleBt";
            this.ListeleBt.Size = new System.Drawing.Size(260, 44);
            this.ListeleBt.TabIndex = 7;
            this.ListeleBt.Text = " Listele";
            this.ListeleBt.Click += new System.EventHandler(this.ListeleBt_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(199, 85);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(218, 30);
            this.TxtAd.TabIndex = 9;
            // 
            // TxtiD
            // 
            this.TxtiD.Location = new System.Drawing.Point(199, 47);
            this.TxtiD.Name = "TxtiD";
            this.TxtiD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtiD.Properties.Appearance.Options.UseFont = true;
            this.TxtiD.Properties.ReadOnly = true;
            this.TxtiD.Size = new System.Drawing.Size(218, 32);
            this.TxtiD.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.TxtTelefon);
            this.groupControl1.Controls.Add(this.TxtEmail);
            this.groupControl1.Controls.Add(this.TxtSoyad);
            this.groupControl1.Controls.Add(this.Departament);
            this.groupControl1.Controls.Add(this.Telefon);
            this.groupControl1.Controls.Add(this.Email);
            this.groupControl1.Controls.Add(this.Soyad);
            this.groupControl1.Controls.Add(this.ElaveEtBt);
            this.groupControl1.Controls.Add(this.ID);
            this.groupControl1.Controls.Add(this.GuncellemeBt);
            this.groupControl1.Controls.Add(this.Ad);
            this.groupControl1.Controls.Add(this.SilBt);
            this.groupControl1.Controls.Add(this.ListeleBt);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.TxtiD);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(471, 550);
            this.groupControl1.TabIndex = 15;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "";
            this.lookUpEdit1.Location = new System.Drawing.Point(199, 224);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(218, 32);
            this.lookUpEdit1.TabIndex = 22;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(199, 193);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefon.Properties.Appearance.Options.UseFont = true;
            this.TxtTelefon.Size = new System.Drawing.Size(218, 30);
            this.TxtTelefon.TabIndex = 21;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(199, 157);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Properties.Appearance.Options.UseFont = true;
            this.TxtEmail.Size = new System.Drawing.Size(218, 30);
            this.TxtEmail.TabIndex = 20;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(199, 121);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyad.Size = new System.Drawing.Size(218, 30);
            this.TxtSoyad.TabIndex = 19;
            // 
            // Departament
            // 
            this.Departament.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departament.Appearance.Options.UseFont = true;
            this.Departament.Location = new System.Drawing.Point(39, 229);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(154, 27);
            this.Departament.TabIndex = 17;
            this.Departament.Text = "Departament:";
            // 
            // Telefon
            // 
            this.Telefon.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefon.Appearance.Options.UseFont = true;
            this.Telefon.Location = new System.Drawing.Point(103, 196);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(90, 27);
            this.Telefon.TabIndex = 16;
            this.Telefon.Text = "Telefon:";
            // 
            // Email
            // 
            this.Email.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Appearance.Options.UseFont = true;
            this.Email.Location = new System.Drawing.Point(123, 161);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(70, 27);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email:";
            // 
            // Soyad
            // 
            this.Soyad.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soyad.Appearance.Options.UseFont = true;
            this.Soyad.Location = new System.Drawing.Point(117, 121);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(76, 27);
            this.Soyad.TabIndex = 14;
            this.Soyad.Text = "Soyad:";
            // 
            // ElaveEtBt
            // 
            this.ElaveEtBt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElaveEtBt.Appearance.Options.UseFont = true;
            this.ElaveEtBt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ElaveEtBt.ImageOptions.Image")));
            this.ElaveEtBt.Location = new System.Drawing.Point(157, 392);
            this.ElaveEtBt.Name = "ElaveEtBt";
            this.ElaveEtBt.Size = new System.Drawing.Size(260, 50);
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
            this.panel1.Size = new System.Drawing.Size(1116, 556);
            this.panel1.TabIndex = 16;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(639, 556);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Location = new System.Drawing.Point(645, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 550);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 556);
            this.panel3.TabIndex = 19;
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1116, 556);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersoneller";
            this.Text = "FrmPersoneller";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtiD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl ID;
        private DevExpress.XtraEditors.SimpleButton GuncellemeBt;
        private DevExpress.XtraEditors.LabelControl Ad;
        private DevExpress.XtraEditors.SimpleButton SilBt;
        private DevExpress.XtraEditors.SimpleButton ListeleBt;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.TextEdit TxtiD;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton ElaveEtBt;
        private DevExpress.XtraEditors.TextEdit TxtTelefon;
        private DevExpress.XtraEditors.TextEdit TxtEmail;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.LabelControl Departament;
        private DevExpress.XtraEditors.LabelControl Telefon;
        private DevExpress.XtraEditors.LabelControl Email;
        private DevExpress.XtraEditors.LabelControl Soyad;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}