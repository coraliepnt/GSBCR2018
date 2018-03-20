using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;
using GSBCR.UC;

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ucMedicament1.Visible = false;
            bsMedoc.DataSource = Manager.ChargerMedicaments();
            cbx_medoc.DataSource = bsMedoc;
            cbx_medoc.ValueMember = "MED_DEPOTLEGAL";
            cbx_medoc.DisplayMember = "MED_NOMCOMMERCIAL";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbx_medoc.SelectedIndex = -1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbx_medoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_medoc.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbx_medoc.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }
        }
    }
}
