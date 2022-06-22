using AppLibrary;
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
    public partial class VisitsForm : Form
    {
        public ClientModel Client { get; set; }
        private LandingForm landingForm { get; set; }
        public VisitsForm(LandingForm getLandingForm)
        {
            InitializeComponent();
            landingForm = getLandingForm;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            landingForm.CloseCurrentTab();
            this.Close();
        }

        private void VisitsForm_Load(object sender, EventArgs e)
        {
            Client.Pets[0].Visits = GlobalConfig.Connection.GetVisitsByPetID(Client.Pets[0].ID);
            pic.BackgroundImage = Client.ImageBitmap;
            name.Text = Client.FullName;
            address.Text = Client.Address;
            cellphone.Text = Client.Cellphone;
            petName.Text = Client.Pets[0].Name;
            species.Text = Client.Pets[0].Species;
            breed.Text = Client.Pets[0].Breed;
            colorMarking.Text = Client.Pets[0].ColorMarking;
            age.Text = Client.Pets[0].Age.ToString();
            sex.Text = Client.Pets[0].Sex;
            foreach(VisitModel visit in Client.Pets[0].Visits)
            {
                string nextVisit = null;
                if (visit.NextVisit.Date != System.Data.SqlTypes.SqlDateTime.MaxValue.Value.Date)
                {
                    nextVisit = visit.NextVisit.ToString();
                }
                visitsData.Rows.Add(new String[] { visit.Date.ToString(), visit.WTT, visit.ComplaintDiagnosis, visit.Treatment, visit.Notes ,nextVisit, visit.Bill.TotalAmount.ToString("₱0.00") });
            }
        }
    }
}
