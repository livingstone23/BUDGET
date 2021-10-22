using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUDGET.DESKTOP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {

    
            InitializeComponent();
        }

        public void pantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        } 

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pantallaOk();

     
            AbrirFormulariosEnWrapper(new FrmDashboard());

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seguirboton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            flecha.Top = sender.Top;
        }

        public void SeleccionarBotones(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnDashboard.Textcolor = Color.White;
            //btnFrmInitiative.Textcolor = Color.White;
            //btnProject.Textcolor = Color.White;
            btnPOSReceived.Textcolor = Color.White;

            sender.selected = true;
            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98,195,140)  ;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SeleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirboton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulariosEnWrapper(new FrmDashboard());
        }

        private void btnFrmInitiative_Click(object sender, EventArgs e)
        {
            SeleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirboton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulariosEnWrapper(new FrmInitiative());
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            SeleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirboton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulariosEnWrapper(new FrmProject());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SeleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirboton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulariosEnWrapper(new FrmPays());
        }

        private Form formActivado = null;

        private void AbrirFormulariosEnWrapper(Form FormHijo)
        {
            if(formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(FormHijo);
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
