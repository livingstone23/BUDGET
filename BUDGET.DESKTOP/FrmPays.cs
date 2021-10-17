using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUDGET.BUSINESS;
using BUDGET.ENTITIES;

namespace BUDGET.DESKTOP
{
    public partial class FrmPays : Form
    {
        public FrmPays()
        {
            InitializeComponent();
        }

        private void FrmPays_Load(object sender, EventArgs e)
        {
            ListarPos("");
            ConfigurarGrid();
        }
        private void ConfigurarGrid()
        {
            //headers visibles
            tablaPays.ColumnHeadersVisible = true;
            //escondemos columnas
            tablaPays.Columns[0].Visible = false;
            tablaPays.Columns[7].Visible = false;
            tablaPays.Columns[8].Visible = false;
            tablaPays.Columns[9].Visible = false;
            tablaPays.Columns[12].Visible = false;
            this.tablaPays.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //cambiamos nombres de headers
            tablaPays.Columns[1].HeaderText = "Pay Day";
            tablaPays.Columns[2].HeaderText = "Currency Pay";
            tablaPays.Columns[3].HeaderText = "Description Pos";
            tablaPays.Columns[4].HeaderText = "Number Transfer";
            tablaPays.Columns[5].HeaderText = "Pay Amount";
            tablaPays.Columns[5].HeaderText = "Rate Change";
            tablaPays.Columns[10].HeaderText = "Initiative Name";
            tablaPays.Columns[11].HeaderText = "Project Name";

        }
        private void ListarPos(string buscar)
        {
            N_POSPay oPos = new N_POSPay();
            tablaPays.DataSource = oPos.ListingPosPay(buscar);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Utilidades.ExportarToFormat.ExportarPDF(tablaPays);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Utilidades.ExportarToFormat.ExportarXml(tablaPays);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarPos(txtBuscar.Text);
        }
    }
}
