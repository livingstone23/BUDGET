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
    public partial class FrmPos : Form
    {
       
        N_POSPay business = new N_POSPay();

        public bool Update = false;
        private bool _pChecked;
        private bool PosChecked
        {
          get;set;
        }


        public FrmPos()
        {
            InitializeComponent();
         
        }
        private void FrmPos_Load(object sender, EventArgs e)
        {
            ListInitiative();
            // ListProject();
            ListPos();
            PosChecked = false;
            chkPos.Checked = PosChecked;
            pictureBoxPos.Visible = false;
            cmbPos.Visible = false;
        }
        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bguardar = true;
            string stBox = "";
            if(Update == false)
            {
                try
                {
                    //Comprobamos que esté relleno los textbox necesarios
                    if (txtDescription.Text == "")
                    {
                        bguardar = false;
                        picBoxDescription.BackColor = Color.Red;
                        stBox = "Description";
                    }
                    if (txtNumberTransfer.Text == "")
                    {
                        bguardar = false;
                        pictureBoxNumTransfer.BackColor = Color.Red;
                        stBox = "Transfer Number";
                    }
                    if (txtPayAmount.Text == "")
                    {
                        bguardar = false;
                        pictureBoxAmount.BackColor = Color.Red;
                        stBox = "Amount";
                    }

                    if (bguardar)
                    {
                        E_POSPay entities = new E_POSPay();
                        entities.PayDay = dtFecha.Value;
                        entities.CurrencyPay = "EURO";
                        entities.DescriptionPOS = txtDescription.Text;
                        entities.NumberTransfer = txtNumberTransfer.Text;
                        entities.PayAmount = Convert.ToDecimal(txtPayAmount.Text);
                        entities.RateChange = 1;
                        entities.IdInitiative = Convert.ToInt32(cmbInitiative.SelectedValue);
                        entities.IdProject = Convert.ToInt32(cmbProject.SelectedValue);
                        if (PosChecked)
                        {
                            entities.IdPOSPaysAdjust = Convert.ToInt32(cmbPos.SelectedValue);
                        } 

                        business.CreatingPOSPay(entities);
                        MessageBox.Show("POS  GUARDADO");
                    }
                    else
                    {
                        MessageBox.Show($"{stBox} box cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar POS" + ex);
                }
            }
            if (Update == true)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar POS" + ex);
                }
            }
        }

        public void ListInitiative()
        {
            N_Initiative initiative = new N_Initiative();
            cmbInitiative.DataSource = initiative.ListInitiative("");
            cmbInitiative.ValueMember = "IdInitiative";
            cmbInitiative.DisplayMember = "InitiativeName";

        }
   
        public void ListProject(string idInitiative)
        {
            N_Project oProject = new N_Project();
            //cmbProject.DataSource = oProject.ListandoProject("");
            cmbProject.DataSource = oProject.getProyectoPorIniciativa(idInitiative);
            cmbProject.ValueMember = "IdProject";
            cmbProject.DisplayMember = "NameProject";
        }

        public void ListPos()
        {
            N_POSPay oPos = new N_POSPay();
            cmbPos.DataSource = oPos.ListingPosPay("");
            cmbPos.ValueMember = "IdPOSPays";
            cmbPos.DisplayMember = "DescriptionPOS";
        }

        private void txtAmount_PressKey(object sender, KeyPressEventArgs e)
        {
            LimpiarErrores();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void LimpiarErrores()
        {
            pictureBoxNumTransfer.BackColor = Color.White;
            picBoxDescription.BackColor = Color.White;
            pictureBoxAmount.BackColor = Color.White;
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarErrores();
        }

        private void txtNumerTransfer_keyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarErrores();
        }

        private void cmbInitiative_SelectedIndexChanged(object sender, EventArgs e)
        {
            //actualizamos combobox proyectos
            E_Initiative oIni = (E_Initiative)cmbInitiative.SelectedItem;
            ListProject(oIni.IdInitiative.ToString());
        }

        private void chkPos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPos.Checked)
            {
                PosChecked = true;
                pictureBoxPos.Visible = true;
                cmbPos.Visible = true;
            }
            else
            {
                PosChecked = false;
                pictureBoxPos.Visible = false;
                cmbPos.Visible = false;
            }
        }
             
    }
}
