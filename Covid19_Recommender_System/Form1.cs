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

        CheckBox[] questions = new CheckBox[3];

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

            questions[0] = chkMasks;
            questions[1] = chkSanitize;
            questions[2] = chkSocial;

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
            cmbVaccine.Enabled = true;
        }

        private void rdoNotVaccinated_CheckedChanged(object sender, EventArgs e)
        {
            vaccination = rdoNotVaccinated.Text;
            cmbVaccine.Enabled = false;
            cmbVaccine.Text = "No Vaccine";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int questionCount = 0;
            string questionAnswers = "";

            string recommand = "";
            string details = "";

            for (int i = 0; i < 3; i++)
            {
                if (questions[i].Checked)
                {
                    questionAnswers += "\r\n" + questions[i].Text + " : Yes";
                    questionCount++;
                }
                else
                {
                    questionAnswers += "\r\n" + questions[i].Text + " : No";
                }
            }

            txtRecommendation.ForeColor = Color.White;

            if (rdoVaccinated.Checked && questionCount==3 && lstYourSymptoms.Items.Count==0)
            {
                txtRecommendation.BackColor = Color.Green;
                recommand = "You are Safe! No action needed.";
            }
            else if(rdoNotVaccinated.Checked && questionCount >= 1 && lstYourSymptoms.Items.Count <= 3)
            {
                txtRecommendation.BackColor = Color.Yellow;
                recommand = "You may not Safe! Home quarantine recommended.";
            }
            else if(rdoNotVaccinated.Checked && questionCount <= 2 && lstYourSymptoms.Items.Count > 3)
            {
                txtRecommendation.BackColor = Color.Red;
                recommand = "You may in Danger! Visit the closest treatment center.";
            }

            details += "\n******* Personal Details *******\n";
            details += "Name: " + txtName.Text;
            details += "\nAge: " + nmcAge.Value.ToString() + " years old";
            details += "\nNIC: " + txtNIC.Text;

            details += "\n******* Vaccination Details *******\n";
            
            if(rdoNotVaccinated.Checked)
            {
                details += "\nNot Vaccinated";
            }
            else if(rdoVaccinated.Checked)
            {
                details += "\nVaccine: "+cmbVaccine.Text;
            }

            details += "\n******* Symptoms *******\n";

            if(lstYourSymptoms.Items.Count==0)
            {
                details += "No Symptoms";
            }
            else
            {
                details += lstYourSymptoms.Text;
            }

            details += "\n******* Health Questions *******\n";

            details += questionAnswers;

            details += "\n" + recommand;

            txtRecommendation.Text = details;
        }
    }
}
