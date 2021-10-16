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
        E_POSPay entities = new E_POSPay();
        N_POSPay business = new N_POSPay();

        public bool Update = false;

        public FrmPos()
        {
            InitializeComponent();
            ListInitiative();
        }

        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Update == false)
            {
                try
                {
                    entities.PayDay = DateTime.Now.Date;
                    entities.CurrencyPay = "EURO";
                    entities.DescriptionPOS = txtDescription.Text;
                    entities.NumberTransfer = txtNumberTransfer.Text;
                    entities.PayAmount = Convert.ToDecimal(txtPayAmount.Text);
                    entities.RateChange = 1;
                    entities.IdInitiative = Convert.ToInt32(cmbInitiative.SelectedValue);
                    entities.IdProject = Convert.ToInt32(cmbProject.SelectedValue);
                    entities.IdPOSPaysAdjust = Convert.ToInt32(cmbPos.SelectedValue);

                    business.CreatingPOSPay(entities);
                    MessageBox.Show("POS  GUARDADO");

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

        public void ListProject()
        {

        }

        public void ListPos()
        {

        }
    }
}
