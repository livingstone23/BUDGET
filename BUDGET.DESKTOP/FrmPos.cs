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
    public partial class FrmPos : Form
    {
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
