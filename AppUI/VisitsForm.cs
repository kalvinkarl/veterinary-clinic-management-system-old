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
            name.Text = Client.FullName;
            address.Text = Client.Address;
            cellphone.Text = Client.Cellphone;
            petName.Text = Client.Pets[0].Name;
            species.Text = Client.Pets[0].Species;
            breed.Text = Client.Pets[0].Breed;
            colorMarking.Text = Client.Pets[0].ColorMarking;
            age.Text = Client.Pets[0].Age.ToString();
            sex.Text = Client.Pets[0].Sex;
        }
    }
}
