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
    public partial class FrmProject : Form
    {
        private string idProject;
        private bool bEditarse = false;
        
        E_Project oEntidad = new E_Project();
        N_Project oProject = new N_Project();
        public bool Mostrar { get; set; }
        public FrmProject()
        {
            InitializeComponent();
        }
        private void FrmProject_Load(object sender, EventArgs e)
        {
            
            ListarProject("");
            
            RellenarCmbIniciativa();
            ConfigurarGrid();

        }
        public void ConfigurarGrid()
        {
            cerrarFormulario.Visible = Mostrar;

            //Hacemos los headers visibles
            tablaProject.ColumnHeadersVisible = true;
            //configuramos los headers
            tablaProject.Columns[1].HeaderText = "Project Name";
            tablaProject.Columns[2].HeaderText = "Description";
            tablaProject.Columns[3].HeaderText = "Amount";
            tablaProject.Columns[4].HeaderText = "Initiative";

            //Para que las columnas se adapten al contenido (wrap content)
            tablaProject.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tablaProject.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tablaProject.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tablaProject.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tablaProject.Columns[0].Visible = false;
            //columna amount le damos formato €
            tablaProject.Columns[3].DefaultCellStyle.Format = "c";


        }
        private void cerrarFormulario_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListarProject(string buscar)
        {
            N_Project oNegProject = new N_Project();
            tablaProject.DataSource = oNegProject.ListandoProject(buscar);
        }
        private void LimpiarCajas()
        {
            txtAmount.Text = "";
            txtDescripcion.Text = "";
            //txtInitiative.Text = "";
            txtNombre.Text = "";
            txtNombre.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
        /// <summary>
        /// Función para controlar que solo se puedan introducir Double
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarErrores();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        private void txtName_keyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarErrores();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            bEditarse = true;
            LimpiarErrores();
            if (tablaProject.SelectedRows.Count > 0)
            {
                idProject = tablaProject.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaProject.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaProject.CurrentRow.Cells[2].Value.ToString();
                txtAmount.Text = tablaProject.CurrentRow.Cells[3].Value.ToString();
                cmbIniciativa.SelectedValue = oProject.GetInitiative(tablaProject.CurrentRow.Cells[4].Value.ToString());

            }
            else
            {
                MessageBox.Show("Select a row to edit");
            }
        }
        private void LimpiarErrores()
        {
            picboxName.BackColor = Color.White;
            picBoxAmount.BackColor = Color.White;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bGuardar = true;
            //controlamos texbox
            if (txtNombre.Text == "")
            {
                bGuardar = false;
                picboxName.BackColor = Color.Red;

            }
            if (txtAmount.Text == "")
            {
                bGuardar = false;
                picBoxAmount.BackColor = Color.Red;

            }
            if (bGuardar)
            {
                if (bEditarse != false)
                {
                    oEntidad.IdProject = Convert.ToInt32(idProject);
                    oEntidad.NameProject = txtNombre.Text.ToUpper();
                    oEntidad.DescripcionProject = txtDescripcion.Text.ToUpper();
                    oEntidad.Amount = Convert.ToDecimal(txtAmount.Text);
                    oEntidad.IdIniciativa = Convert.ToInt32(cmbIniciativa.SelectedValue);
                    oProject.EditarProjecT(oEntidad);
                    MessageBox.Show("Project edited successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProject("");
                    LimpiarCajas();
                    bEditarse = false;
                }
                else
                {
                    //guardamos
                    try
                    {
                        oEntidad.IdProject = Convert.ToInt32(idProject);
                        oEntidad.NameProject = txtNombre.Text.ToUpper();
                        oEntidad.DescripcionProject = txtDescripcion.Text.ToUpper();
                        oEntidad.Amount = Convert.ToDecimal(txtAmount.Text);
                        oEntidad.IdIniciativa = Convert.ToInt32(cmbIniciativa.SelectedValue);

                        oProject.InsertandoProject(oEntidad);
                        MessageBox.Show("New project created", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarProject("");
                        LimpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        bEditarse = false;
                        MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaProject.SelectedRows.Count > 0)
            {

                //guardamos los valores en el objeto entidad
                oEntidad.IdProject = Convert.ToInt32(tablaProject.CurrentRow.Cells[0].Value.ToString());
                oEntidad.NameProject = tablaProject.CurrentRow.Cells[1].Value.ToString();
                //comprobamos si el proyecto está asociado a un pos
                N_Budget oBudget = new N_Budget();
                DataTable tablaBudget = oBudget.ListandoBudget();
                List<int> ltIds = tablaBudget.AsEnumerable().Select(x => x.Field<int>("IdProject")).ToList();
                if (ltIds.Contains(oEntidad.IdProject))
                {
                    MessageBox.Show("You cannot delete a project that already has an associated POS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Do you want delete {oEntidad.NameProject} Project? ", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        oProject.EliminarProject(oEntidad);
                        ListarProject("");
                    }
                }
                //liberamos memoria
                oBudget = null;
                tablaBudget = null;
                ltIds.Clear();
                ltIds = null;
            }

        }
        public void RellenarCmbIniciativa()
        {
            N_Initiative oIni = new N_Initiative();
            cmbIniciativa.DataSource = oIni.ListInitiative("");
            cmbIniciativa.ValueMember = "IdInitiative";
            cmbIniciativa.DisplayMember = "InitiativeName";

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarProject(txtBuscar.Text);
        }
        //private void copyAlltoClipboard()
        //{
        //    tablaProject.SelectAll();
        //    DataObject dataObj = tablaProject.GetClipboardContent();
        //    if (dataObj != null)
        //        Clipboard.SetDataObject(dataObj);
        //}
        private void btnExportarExcel(object sender, EventArgs e)
        {
            Utilidades.ExpExcel.Exportar(tablaProject);
            //copyAlltoClipboard();
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Microsoft.Office.Interop.Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
