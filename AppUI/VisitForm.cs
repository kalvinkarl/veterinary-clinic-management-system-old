using AppLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class VisitForm : Form
    {
        public BillModel Bill { get; set; } = new BillModel();
        public VisitModel Visit { get; set; }
        public VisitForm()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            if(weight.Value == 0)
            {
                MessageBox.Show("Pet weight is not valid. Please try again.");
                return false;
            }
            else if(temp.Value == 0)
            {
                MessageBox.Show("Pet temperature is not valid. Please try again.");
                return false;
            }
            else if(complaintDiagnosis.Text == "")
            {
                MessageBox.Show("Please enter the complaint or diagnosis of the patient.");
                return false;
            }
            else if(treatment.Text == "")
            {
                MessageBox.Show("Please specify method of treatment to continue.");
                return false;
            }
            return true;
        }
        private void Pay(bool later)
        {
            if (ValidateForm())
            {
                PaymentForm paymentForm = new PaymentForm();
                paymentForm.PayLater = later;
                paymentForm.ShowDialog(this);
                if (paymentForm.Bill != null)
                {
                    Bill = paymentForm.Bill;
                    Visit = new VisitModel();
                    Visit.Weight = $"{weight.Text} {weightUnit.Text}";
                    Visit.Temperature = $"{temp.Text} {tempUnit.Text}";
                    Visit.ComplaintDiagnosis = complaintDiagnosis.Text;
                    Visit.Treatment = treatment.Text;
                    Visit.Notes = notes.Text;
                    Visit.Date = DateTime.Parse(date.Text);
                    if (appGroup.Visible)
                    {
                        Visit.NextVisit = DateTime.Parse($"{DateTime.Parse(appDate.Text).ToString("yyyy-MM-dd")} {DateTime.Parse($"{appHour.Value}:{appMinute.Value} {ampm.Text}").ToString("HH:mm")}");
                    }
                    this.Close();
                    //MessageBox.Show(DateTime.Parse($"{DateTime.Parse(appDate.Text).ToString("yyyy-MM-dd")} {DateTime.Parse($"{appHour.Value}:{appMinute.Value} {ampm.Text}").ToString("HH:mm")}").ToString());
                }
            }
        }
        private void paymentButton_Click(object sender, EventArgs e)
        {
            Pay(false);
        }
        private void laterButton_Click(object sender, EventArgs e)
        {
            Pay(true);
        }
        private void appOpenClose_Click(object sender, EventArgs e)
        {
            appGroup.Visible = !appGroup.Visible;
        }
        private void ampm_Click(object sender, EventArgs e)
        {
            if(ampm.Text == "AM")
            {
                ampm.Text = "PM";
            }
            else
            {
                ampm.Text = "AM";
            }
            appHour.Focus();
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            if(Visit != null)
            {
                string[] w = Visit.Weight.Split(' ');
                string[] t = Visit.Temperature.Split(' ');
                weight.Value = decimal.Parse(w[0]);
                weightUnit.Text = w[1];
                temp.Value = decimal.Parse(t[0]);
                tempUnit.Text = t[1];
                complaintDiagnosis.Text = Visit.ComplaintDiagnosis;
                treatment.Text = Visit.Treatment;
                notes.Text = Visit.Notes;
            }
            tempUnit.SelectedIndex = 0;
            weightUnit.SelectedIndex = 0;
        }
    }
}
