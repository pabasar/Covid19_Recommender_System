using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19_Recommender_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string vaccination;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstAllSymptoms.Items.Add("Fever");
            lstAllSymptoms.Items.Add("Cough");
            lstAllSymptoms.Items.Add("Tiredness");
            lstAllSymptoms.Items.Add("Loss of taste or smell");
            lstAllSymptoms.Items.Add("Sore throat");
            lstAllSymptoms.Items.Add("Headache");
            lstAllSymptoms.Items.Add("Difficulty Breathing");

            lstAllSymptoms.Sorted = true;

            rdoNotVaccinated.Select();

            cmbVaccine.Text = "No Vaccine";
            cmbVaccine.Items.Add("Pfizer");
            cmbVaccine.Items.Add("Moderna");
            cmbVaccine.Items.Add("AstraZeneca");
            cmbVaccine.Items.Add("Sinopharm");
            cmbVaccine.Items.Add("Sputnik V");
        }

        private void lstAllSymptoms_DoubleClick(object sender, EventArgs e)
        {
            if (lstAllSymptoms.Items.Count != 0)
            {
                lstYourSymptoms.Items.Add(lstAllSymptoms.Items[lstAllSymptoms.SelectedIndex]);
                lstYourSymptoms.Sorted = true;
            }
        }

        private void rdoVaccinated_CheckedChanged(object sender, EventArgs e)
        {
            vaccination = rdoVaccinated.Text;
        }

        private void rdoNotVaccinated_CheckedChanged(object sender, EventArgs e)
        {
            vaccination = rdoNotVaccinated.Text;
        }
    }
}
