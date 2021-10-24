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
        E_POSPay _oPosPay = new E_POSPay();
        public bool bEditar { get; set; }
        private bool _pChecked;
        
        public bool PosChecked
        {
          get;set;
        }


        public FrmPos()
        {
            InitializeComponent();
         
        }
        public FrmPos(E_POSPay oPosPay)
        {
            _oPosPay = oPosPay;
            InitializeComponent();
            
            //se va a editar el pos
           
        }
        private void FrmPos_Load(object sender, EventArgs e)
        {

            ListInitiative();
            // ListProject();
            ListPos();
     
            if (bEditar)
            {
                //obtenemos el objeto del pago
                txtDescription.Text = _oPosPay.DescriptionPOS;
                txtNumberTransfer.Text = _oPosPay.NumberTransfer;
                txtPayAmount.Text = _oPosPay.PayAmount.ToString();
                dtFecha.Value = _oPosPay.PayDay;
                cmbInitiative.SelectedValue = _oPosPay.IdInitiative;
                cmbProject.SelectedValue = _oPosPay.IdProject;
                if(_oPosPay.IdPOSPaysAdjust != 0)
                {
                    cmbPos.SelectedValue = _oPosPay.IdPOSPaysAdjust;
                    chkPos.Checked = PosChecked;
                }
                else
                {
                    PosChecked = false;
                    chkPos.Checked = PosChecked;
                    pictureBoxPos.Visible = false;
                    cmbPos.Visible = false;
                }
            }
            else
            {
                PosChecked = false;
                chkPos.Checked = PosChecked;
                pictureBoxPos.Visible = false;
                cmbPos.Visible = false;
            }
         
            
        }
        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bguardar = true;
            string stBox = "";
            if(!bEditar)
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
            else
            {
                try
                {
                    //guardamos objeto editado
                    E_POSPay entities = new E_POSPay();
                    entities.IdPOSPays = _oPosPay.IdPOSPays;
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
                    business.EditPosPay(entities);
                    bEditar = false;
                    MessageBox.Show("Pos Pay edited successfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
