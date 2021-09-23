namespace BUDGET.DESKTOP
{
    partial class FrmCategoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrarFormulario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // TopFormulario
            // 
            this.TopFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.TopFormulario.Controls.Add(this.label1);
            this.TopFormulario.Controls.Add(this.cerrarFormulario);
            this.TopFormulario.Controls.Add(this.pictureBox1);
            this.TopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFormulario.Location = new System.Drawing.Point(0, 0);
            this.TopFormulario.Name = "TopFormulario";
            this.TopFormulario.Size = new System.Drawing.Size(800, 55);
            this.TopFormulario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cerrarFormulario
            // 
            this.cerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("cerrarFormulario.Image")));
            this.cerrarFormulario.Location = new System.Drawing.Point(750, 3);
            this.cerrarFormulario.Name = "cerrarFormulario";
            this.cerrarFormulario.Size = new System.Drawing.Size(47, 47);
            this.cerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarFormulario.TabIndex = 2;
            this.cerrarFormulario.TabStop = false;
            this.cerrarFormulario.Click += new System.EventHandler(this.cerrarFormulario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(72, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoria";
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.TopFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cerrarFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
    }
}