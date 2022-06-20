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
    public partial class PetForm : Form
    {
        public BillModel Bill { get; set; } = new BillModel();
        public VisitModel Visit { get; set; }
        public PetModel Pet { get; set; }
        public PetForm()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            if(name.Text == string.Empty)
            {
                MessageBox.Show("invalid");
                return false;
            }
            return true;
        }
        private void Save()
        {
            Pet = new PetModel();
            Pet.Name = name.Text;
            Pet.Species = species.Text;
            Pet.Breed = breed.Text;
            Pet.ColorMarking = colorMarking.Text;
            Pet.Age = int.Parse(age.Text);
            Pet.Sex = getSex();
            Pet.Notes = notes.Text;
        }
        private string getSex()
        {
            string sex = "";
            if (male.Checked)
            {
                sex = "Male";
            }
            else if (female.Checked)
            {
                sex = "Female";
            }
            return sex;
        }
        private void PetForm_Load(object sender, EventArgs e)
        {
            if(Pet != null)
            {
                name.Text = Pet.Name;
                species.Text = Pet.Species;
                breed.Text = Pet.Breed;
                colorMarking.Text = Pet.ColorMarking;
                age.Text = Pet.Age.ToString();
                if (Pet.Sex == "Male")
                {
                    male.Checked = true;
                }
                else
                {
                    female.Checked = true;
                }
                notes.Text = Pet.Notes;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                Save();
                this.Close();
            }
        }
        private void consultButton_Click(object sender, EventArgs e)
        {
            VisitForm visit = new VisitForm();
            if(Visit != null)
            {
                visit.Visit = Visit;
            }
            visit.ShowDialog(this);
            if(visit.Visit != null)
            {
                Visit = new VisitModel();
                Visit = visit.Visit;
                Bill = visit.Bill;
                MessageBox.Show($"{Visit.Weight} {Visit.Temperature}");
                MessageBox.Show("Meron");
            }
            else
            {
                MessageBox.Show("wala");
            }
            //TODO - IF Visit is done,save and close else, not close.
            //this.Close();
        }
    }
}
