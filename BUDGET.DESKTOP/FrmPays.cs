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

        E_POSPay oEntidad = new E_POSPay();
        N_POSPay oPosPay = new N_POSPay();
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
            tablaPays.Columns[6].HeaderText = "Rate Change";
            tablaPays.Columns[10].HeaderText = "Initiative Name";
            tablaPays.Columns[11].HeaderText = "Project Name";
            

            tablaPays.Columns[5].DefaultCellStyle.Format = "c";
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

        private void btnEditarPos_Click(object sender, EventArgs e)
        {
            if (tablaPays.SelectedRows.Count > 0)
            {
                bool bAjuste = false; ;
                //guardamos los valores en objeto entidad
                E_POSPay oPos = new E_POSPay();
                oPos.IdPOSPays = Convert.ToInt32(tablaPays.CurrentRow.Cells[0].Value.ToString());
                oPos.PayDay = (DateTime)tablaPays.CurrentRow.Cells[1].Value;
                oPos.DescriptionPOS= tablaPays.CurrentRow.Cells[3].Value.ToString();
                oPos.NumberTransfer = tablaPays.CurrentRow.Cells[4].Value.ToString();
                oPos.PayAmount = Convert.ToDecimal(tablaPays.CurrentRow.Cells[5].Value);
                oPos.IdInitiative = Convert.ToInt32(tablaPays.CurrentRow.Cells[7].Value);
                oPos.IdProject = Convert.ToInt32(tablaPays.CurrentRow.Cells[8].Value);

                if (tablaPays.CurrentRow.Cells[9].Value.ToString() != ""){
                    
                    oPos.IdPOSPaysAdjust = Convert.ToInt32(tablaPays.CurrentRow.Cells[9].Value.ToString());
                    bAjuste = true;
                }
                FrmPos fpos = new FrmPos(oPos);
                if (bAjuste)
                    fpos.PosChecked = true;
                fpos.bEditar = true;
                fpos.ShowDialog();
                ListarPos("");
                bAjuste = false;
            }
        }
     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaPays.SelectedRows.Count > 0)
            {
                //guardamos los valores en objeto entidad

                
                
                
                 DataTable t =  oPosPay.ListingPosPay("");
                List<int?> ltIds = t.AsEnumerable().Select(x => x.Field<int?>("IdPOSPaysAdjust")).ToList();
               


                int idPosPay = Convert.ToInt32(tablaPays.CurrentRow.Cells[0].Value.ToString());

               if(idPosPay != 0)
               {
                    if (ltIds.Count > 0 && !ltIds.Contains(idPosPay))
                    {
                        oPosPay.DeletingProducts(idPosPay);
                    }
                    else
                    {
                        MessageBox.Show("A Adjustment with PO associated can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ListarPos("");
            }
        }
    }
}
