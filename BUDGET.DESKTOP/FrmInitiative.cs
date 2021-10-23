using BUDGET.BUSINESS;
using BUDGET.ENTITIES;
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
    public partial class FrmInitiative : Form
    {
        private string idInitiative;
        private bool Editarse = false;

        E_Initiative objEntidad = new E_Initiative();
        N_Initiative objNegocio = new N_Initiative();

        public bool Mostrar { get; set; }
        public FrmInitiative()
        {
            InitializeComponent();
        }

        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void accionesTablas()
        {
            tablaCategoria.Columns[0].Visible =false;
            tablaCategoria.Columns[2].Visible = false;
            tablaCategoria.Columns[1].Width = 20;
            //tablaCategoria.Columns[2].Width = 70;

            tablaCategoria.ClearSelection();
        }

        private void FrmInitiative_Load(object sender, EventArgs e)
        {
            
            mostrarBuscarTabla("");
            accionesTablas();
            cerrarFormulario.Visible = Mostrar;
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Initiative objNegocio = new N_Initiative();
            tablaCategoria.DataSource = objNegocio.ListInitiative(buscar);
        }

        private void tablaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEntidad.InitiativeName = txtNombre.Text.ToUpper();
                    objEntidad.InitiativeDescription = txtDescripcion.Text.ToUpper();

                    objNegocio.InsertInitiative(objEntidad);
                    MessageBox.Show("New Initiative created");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puedo guardar registro" + ex); ;
                }
            }

            if (Editarse == true)
            {
                try
                {
                    objEntidad.IdInitiative = Convert.ToInt32(idInitiative);
                    objEntidad.InitiativeName = txtNombre.Text.ToUpper();
                    objEntidad.InitiativeDescription = txtDescripcion.Text.ToUpper();

                    objNegocio.EditInitiative(objEntidad);
                    MessageBox.Show("Se edito registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();
                    Editarse = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puedo editar registro" + ex); ;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }

        public void limpiarCajas()
        {
            Editarse = false;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaCategoria.SelectedRows.Count > 0)
            {
                Editarse = true;
                idInitiative = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(tablaCategoria.SelectedRows.Count > 0)
            {

                //comprobamos si la iniciativa tiene un proyecto asociado
                N_Project oProject = new N_Project();
                List<E_Project> ltProjects = new List<E_Project>();

                objEntidad.IdInitiative =Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString());
                objEntidad.InitiativeName = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                ltProjects = oProject.getProyectoPorIniciativa(objEntidad.IdInitiative.ToString());

                if (ltProjects.Count > 0)
                {
                    MessageBox.Show("A Initiative with Project associated can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete {objEntidad.InitiativeName} Initiative? ", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        objNegocio.DeleteInitiative(objEntidad);
                        mostrarBuscarTabla("");
                    }
                }
                //liberamos memoria
                oProject = null;
                ltProjects.Clear();
                ltProjects = null;
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
           
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Utilidades.ExportarToFormat.ExportarXml(tablaCategoria);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Utilidades.ExportarToFormat.ExportarPDF(tablaCategoria);
        }
    }
}
