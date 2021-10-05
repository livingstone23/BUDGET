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


        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tablaBUDGET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
