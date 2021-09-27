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

        public FrmInitiative()
        {
            InitializeComponent();
        }

        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    MessageBox.Show("Se guardo registro");
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
                objEntidad.IdInitiative =Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString());
                objNegocio.DeleteInitiative(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
        }
    }
}
