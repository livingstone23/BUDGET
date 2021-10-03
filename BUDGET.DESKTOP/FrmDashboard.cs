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
            tablaBUDGET.Columns[2].Visible = false;

            tablaBUDGET.ClearSelection();
        }


        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
