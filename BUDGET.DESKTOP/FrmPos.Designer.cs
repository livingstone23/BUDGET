
namespace BUDGET.DESKTOP
{
    partial class FrmPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPos));
            this.TopFormulario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cerrarFormulario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picBoxDescription = new System.Windows.Forms.PictureBox();
            this.txtNumberTransfer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNumTransfer = new System.Windows.Forms.PictureBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxAmount = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPos = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbInitiative = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbPos = new System.Windows.Forms.ComboBox();
            this.chkPos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.TopFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPos)).BeginInit();
            this.SuspendLayout();
            // 
            // TopFormulario
            // 
            this.TopFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.TopFormulario.Controls.Add(this.label2);
            this.TopFormulario.Controls.Add(this.cerrarFormulario);
            this.TopFormulario.Controls.Add(this.pictureBox1);
            this.TopFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopFormulario.Location = new System.Drawing.Point(0, 0);
            this.TopFormulario.Name = "TopFormulario";
            this.TopFormulario.Size = new System.Drawing.Size(419, 46);
            this.TopFormulario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PO\'s Received";
            // 
            // cerrarFormulario
            // 
            this.cerrarFormulario.Image = ((System.Drawing.Image)(resources.GetObject("cerrarFormulario.Image")));
            this.cerrarFormulario.Location = new System.Drawing.Point(354, 3);
            this.cerrarFormulario.Name = "cerrarFormulario";
            this.cerrarFormulario.Size = new System.Drawing.Size(38, 35);
            this.cerrarFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarFormulario.TabIndex = 2;
            this.cerrarFormulario.TabStop = false;
            this.cerrarFormulario.Click += new System.EventHandler(this.cerrarFormulario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(39, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(336, 17);
            this.txtDescription.TabIndex = 27;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "DESCRIPTION";
            // 
            // picBoxDescription
            // 
            this.picBoxDescription.BackColor = System.Drawing.Color.White;
            this.picBoxDescription.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDescription.Image")));
            this.picBoxDescription.Location = new System.Drawing.Point(34, 94);
            this.picBoxDescription.Name = "picBoxDescription";
            this.picBoxDescription.Size = new System.Drawing.Size(347, 34);
            this.picBoxDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDescription.TabIndex = 25;
            this.picBoxDescription.TabStop = false;
            // 
            // txtNumberTransfer
            // 
            this.txtNumberTransfer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberTransfer.Location = new System.Drawing.Point(39, 165);
            this.txtNumberTransfer.Name = "txtNumberTransfer";
            this.txtNumberTransfer.Size = new System.Drawing.Size(337, 17);
            this.txtNumberTransfer.TabIndex = 33;
            this.txtNumberTransfer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerTransfer_keyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "NUMBER TRANSFER";
            // 
            // pictureBoxNumTransfer
            // 
            this.pictureBoxNumTransfer.BackColor = System.Drawing.Color.White;
            this.pictureBoxNumTransfer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNumTransfer.Image")));
            this.pictureBoxNumTransfer.Location = new System.Drawing.Point(34, 156);
            this.pictureBoxNumTransfer.Name = "pictureBoxNumTransfer";
            this.pictureBoxNumTransfer.Size = new System.Drawing.Size(347, 34);
            this.pictureBoxNumTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNumTransfer.TabIndex = 31;
            this.pictureBoxNumTransfer.TabStop = false;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayAmount.Location = new System.Drawing.Point(39, 230);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(336, 17);
            this.txtPayAmount.TabIndex = 36;
            this.txtPayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_PressKey);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "PAY AMOUNT";
            // 
            // pictureBoxAmount
            // 
            this.pictureBoxAmount.BackColor = System.Drawing.Color.White;
            this.pictureBoxAmount.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAmount.Image")));
            this.pictureBoxAmount.Location = new System.Drawing.Point(34, 221);
            this.pictureBoxAmount.Name = "pictureBoxAmount";
            this.pictureBoxAmount.Size = new System.Drawing.Size(347, 34);
            this.pictureBoxAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAmount.TabIndex = 34;
            this.pictureBoxAmount.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "PROJECT";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(34, 289);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(347, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "INITIATIVE";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(34, 356);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(347, 34);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBoxPos
            // 
            this.pictureBoxPos.BackColor = System.Drawing.Color.White;
            this.pictureBoxPos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPos.Image")));
            this.pictureBoxPos.Location = new System.Drawing.Point(34, 475);
            this.pictureBoxPos.Name = "pictureBoxPos";
            this.pictureBoxPos.Size = new System.Drawing.Size(347, 34);
            this.pictureBoxPos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPos.TabIndex = 43;
            this.pictureBoxPos.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "SAVE";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 45D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(76, 524);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(270, 29);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "SAVE";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbInitiative
            // 
            this.cmbInitiative.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInitiative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInitiative.ForeColor = System.Drawing.Color.Gray;
            this.cmbInitiative.FormattingEnabled = true;
            this.cmbInitiative.Location = new System.Drawing.Point(37, 296);
            this.cmbInitiative.Name = "cmbInitiative";
            this.cmbInitiative.Size = new System.Drawing.Size(341, 21);
            this.cmbInitiative.TabIndex = 47;
            this.cmbInitiative.SelectedIndexChanged += new System.EventHandler(this.cmbInitiative_SelectedIndexChanged);
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProject.ForeColor = System.Drawing.Color.Gray;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(36, 363);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(342, 21);
            this.cmbProject.TabIndex = 48;
            // 
            // cmbPos
            // 
            this.cmbPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPos.ForeColor = System.Drawing.Color.Gray;
            this.cmbPos.FormattingEnabled = true;
            this.cmbPos.Location = new System.Drawing.Point(36, 482);
            this.cmbPos.Name = "cmbPos";
            this.cmbPos.Size = new System.Drawing.Size(342, 21);
            this.cmbPos.TabIndex = 49;
            // 
            // chkPos
            // 
            this.chkPos.AutoSize = true;
            this.chkPos.Location = new System.Drawing.Point(34, 452);
            this.chkPos.Name = "chkPos";
            this.chkPos.Size = new System.Drawing.Size(124, 17);
            this.chkPos.TabIndex = 50;
            this.chkPos.Text = "POS ADJUSTMENT";
            this.chkPos.UseVisualStyleBackColor = true;
            this.chkPos.CheckedChanged += new System.EventHandler(this.chkPos_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "DATE";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(34, 419);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 52;
            // 
            // FrmPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 581);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPos);
            this.Controls.Add(this.cmbPos);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.cmbInitiative);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBoxPos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxAmount);
            this.Controls.Add(this.txtNumberTransfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxNumTransfer);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picBoxDescription);
            this.Controls.Add(this.TopFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pays";
            this.Load += new System.EventHandler(this.FrmPos_Load);
            this.TopFormulario.ResumeLayout(false);
            this.TopFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopFormulario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cerrarFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picBoxDescription;
        private System.Windows.Forms.TextBox txtNumberTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNumTransfer;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBoxPos;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.ComboBox cmbInitiative;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbPos;
        private System.Windows.Forms.CheckBox chkPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}