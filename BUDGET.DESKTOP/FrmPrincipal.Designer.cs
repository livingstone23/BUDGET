
namespace BUDGET.DESKTOP
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.sidebar = new System.Windows.Forms.Panel();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.btnPOSReceived = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProject = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFrmInitiative = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.sidebar.Controls.Add(this.flecha);
            this.sidebar.Controls.Add(this.btnPOSReceived);
            this.sidebar.Controls.Add(this.btnProject);
            this.sidebar.Controls.Add(this.btnFrmInitiative);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(270, 940);
            this.sidebar.TabIndex = 0;
            // 
            // flecha
            // 
            this.flecha.Image = ((System.Drawing.Image)(resources.GetObject("flecha.Image")));
            this.flecha.Location = new System.Drawing.Point(217, 115);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(53, 40);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 6;
            this.flecha.TabStop = false;
            // 
            // btnPOSReceived
            // 
            this.btnPOSReceived.Activecolor = System.Drawing.Color.Transparent;
            this.btnPOSReceived.BackColor = System.Drawing.Color.Transparent;
            this.btnPOSReceived.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPOSReceived.BorderRadius = 0;
            this.btnPOSReceived.ButtonText = "   POSRECEIVED";
            this.btnPOSReceived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOSReceived.DisabledColor = System.Drawing.Color.Gray;
            this.btnPOSReceived.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPOSReceived.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPOSReceived.Iconimage")));
            this.btnPOSReceived.Iconimage_right = null;
            this.btnPOSReceived.Iconimage_right_Selected = null;
            this.btnPOSReceived.Iconimage_Selected = null;
            this.btnPOSReceived.IconMarginLeft = 0;
            this.btnPOSReceived.IconMarginRight = 0;
            this.btnPOSReceived.IconRightVisible = true;
            this.btnPOSReceived.IconRightZoom = 0D;
            this.btnPOSReceived.IconVisible = true;
            this.btnPOSReceived.IconZoom = 65D;
            this.btnPOSReceived.IsTab = true;
            this.btnPOSReceived.Location = new System.Drawing.Point(24, 332);
            this.btnPOSReceived.Name = "btnPOSReceived";
            this.btnPOSReceived.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPOSReceived.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btnPOSReceived.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPOSReceived.selected = false;
            this.btnPOSReceived.Size = new System.Drawing.Size(223, 40);
            this.btnPOSReceived.TabIndex = 5;
            this.btnPOSReceived.Text = "   POSRECEIVED";
            this.btnPOSReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOSReceived.Textcolor = System.Drawing.Color.White;
            this.btnPOSReceived.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOSReceived.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnProject
            // 
            this.btnProject.Activecolor = System.Drawing.Color.Transparent;
            this.btnProject.BackColor = System.Drawing.Color.Transparent;
            this.btnProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProject.BorderRadius = 0;
            this.btnProject.ButtonText = "   PROJECT";
            this.btnProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject.DisabledColor = System.Drawing.Color.Gray;
            this.btnProject.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProject.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProject.Iconimage")));
            this.btnProject.Iconimage_right = null;
            this.btnProject.Iconimage_right_Selected = null;
            this.btnProject.Iconimage_Selected = null;
            this.btnProject.IconMarginLeft = 0;
            this.btnProject.IconMarginRight = 0;
            this.btnProject.IconRightVisible = true;
            this.btnProject.IconRightZoom = 0D;
            this.btnProject.IconVisible = true;
            this.btnProject.IconZoom = 65D;
            this.btnProject.IsTab = true;
            this.btnProject.Location = new System.Drawing.Point(24, 259);
            this.btnProject.Name = "btnProject";
            this.btnProject.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProject.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btnProject.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProject.selected = false;
            this.btnProject.Size = new System.Drawing.Size(223, 40);
            this.btnProject.TabIndex = 4;
            this.btnProject.Text = "   PROJECT";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProject.Textcolor = System.Drawing.Color.White;
            this.btnProject.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnFrmInitiative
            // 
            this.btnFrmInitiative.Activecolor = System.Drawing.Color.Transparent;
            this.btnFrmInitiative.BackColor = System.Drawing.Color.Transparent;
            this.btnFrmInitiative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrmInitiative.BorderRadius = 0;
            this.btnFrmInitiative.ButtonText = "   INITIATIVE";
            this.btnFrmInitiative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmInitiative.DisabledColor = System.Drawing.Color.Gray;
            this.btnFrmInitiative.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFrmInitiative.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFrmInitiative.Iconimage")));
            this.btnFrmInitiative.Iconimage_right = null;
            this.btnFrmInitiative.Iconimage_right_Selected = null;
            this.btnFrmInitiative.Iconimage_Selected = null;
            this.btnFrmInitiative.IconMarginLeft = 0;
            this.btnFrmInitiative.IconMarginRight = 0;
            this.btnFrmInitiative.IconRightVisible = true;
            this.btnFrmInitiative.IconRightZoom = 0D;
            this.btnFrmInitiative.IconVisible = true;
            this.btnFrmInitiative.IconZoom = 65D;
            this.btnFrmInitiative.IsTab = true;
            this.btnFrmInitiative.Location = new System.Drawing.Point(24, 183);
            this.btnFrmInitiative.Name = "btnFrmInitiative";
            this.btnFrmInitiative.Normalcolor = System.Drawing.Color.Transparent;
            this.btnFrmInitiative.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btnFrmInitiative.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFrmInitiative.selected = false;
            this.btnFrmInitiative.Size = new System.Drawing.Size(223, 40);
            this.btnFrmInitiative.TabIndex = 3;
            this.btnFrmInitiative.Text = "   INITIATIVE";
            this.btnFrmInitiative.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmInitiative.Textcolor = System.Drawing.Color.White;
            this.btnFrmInitiative.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmInitiative.Click += new System.EventHandler(this.btnFrmInitiative_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "   DASHBOARD";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 65D;
            this.btnDashboard.IsTab = true;
            this.btnDashboard.Location = new System.Drawing.Point(24, 115);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(195)))), ((int)(((byte)(140)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(223, 40);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "   DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "BUDGET";
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Wrapper.Location = new System.Drawing.Point(270, 66);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1116, 874);
            this.Wrapper.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.header.Controls.Add(this.btnMinimizar);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.salir);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(270, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1170, 60);
            this.header.TabIndex = 2;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(1123, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(35, 35);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 0;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1081, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1440, 940);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnPOSReceived;
        private Bunifu.Framework.UI.BunifuFlatButton btnProject;
        private Bunifu.Framework.UI.BunifuFlatButton btnFrmInitiative;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.PictureBox flecha;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}