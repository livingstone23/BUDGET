using BUDGET.BUSINESS;
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
    public partial class FrmDashboard : Form
    {
        N_Budget objNegocio = new N_Budget();

        public FrmDashboard()
        {
            InitializeComponent();
            MostrarTablaBudget();
            accionesTAblas();
        }


        
        public void MostrarTablaBudget()
        {
            N_Budget objNegocio = new N_Budget();
        

            tablaBUDGET.DataSource = objNegocio.ListandoBudget();
            tablaBUDGET.Columns[1].HeaderText = "Initiative";
            tablaBUDGET.Columns[3].HeaderText = "Project";
            tablaBUDGET.Columns[4].HeaderText = "Amount Invoice";
            tablaBUDGET.Columns[8].HeaderText = "Final Balance";

        }

        public void accionesTAblas()
        {
            tablaBUDGET.Columns[0].Visible = false;


            tablaBUDGET.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            tablaBUDGET.Columns[2].Visible = false;

            tablaBUDGET.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            



            tablaBUDGET.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tablaBUDGET.Columns[4].DefaultCellStyle.Format = "N2";

            tablaBUDGET.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tablaBUDGET.Columns[5].DefaultCellStyle.Format = "N2";

            tablaBUDGET.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tablaBUDGET.Columns[6].DefaultCellStyle.Format = "N2";

            tablaBUDGET.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tablaBUDGET.Columns[7].DefaultCellStyle.Format = "N2";

            tablaBUDGET.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tablaBUDGET.Columns[8].DefaultCellStyle.Format = "N2";


            tablaBUDGET.ClearSelection();
        }

        private void btnInitiative_Click(object sender, EventArgs e)
        {
            FrmInitiative fini = new FrmInitiative();
            fini.ShowDialog();

        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            FrmPos fpos = new FrmPos();
            fpos.ShowDialog();
        }
    }
}
