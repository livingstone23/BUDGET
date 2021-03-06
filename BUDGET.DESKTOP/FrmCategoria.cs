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
    public partial class FrmCategoria : Form
    {
        private string idCategoria;
        private bool Editarse = false;

        E_Categoria objEntidad = new E_Categoria();
        N_Categoria objNegocio = new N_Categoria();

        public FrmCategoria()
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
            tablaCategoria.Columns[1].Width = 70;
            tablaCategoria.Columns[2].Width = 100;

            tablaCategoria.ClearSelection();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTablas();
        }

        public void mostrarBuscarTabla(string buscar)
        {
            N_Categoria objNegocio = new N_Categoria();
            tablaCategoria.DataSource = objNegocio.ListandoCategoria(buscar);
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
                    objEntidad.Nombrecategoria = txtNombre.Text.ToUpper();
                    objEntidad.Descripcioncategoria = txtDescripcion.Text.ToUpper();

                    objNegocio.InsertandoCategoria(objEntidad);
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
                    objEntidad.Idcategoria = Convert.ToInt32(idCategoria);
                    objEntidad.Nombrecategoria = txtNombre.Text.ToUpper();
                    objEntidad.Descripcioncategoria = txtDescripcion.Text.ToUpper();

                    objNegocio.EditandoCategoria(objEntidad);
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
            txtCodigo.Text = "";
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
                idCategoria = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = tablaCategoria.CurrentRow.Cells[3].Value.ToString();
                
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
                objEntidad.Idcategoria =Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoCategoria(objEntidad);

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
