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
        private bool Saved { get; set; }
        public BillModel Bill { get; set; } = new BillModel();
        public VisitModel Visit { get; set; }
        public PetModel Pet { get; set; }
        public PetForm()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            if (name.Text == String.Empty)
            {
                MessageBox.Show("Invalid name");
                return false;
            }
            else if (species.Text == String.Empty)
            {
                MessageBox.Show("Invalid species");
                return false;
            }
            else if (breed.Text == String.Empty)
            {
                MessageBox.Show("Invalid breed");
                return false;
            }
            else if (colorMarking.Text == String.Empty)
            {
                MessageBox.Show("Invalid color marking");
                return false;
            }
            else if (age.Value <= 0)
            {
                MessageBox.Show("Invalid age");
                return false;
            }
            else if (male.Checked == false && female.Checked == false)
            {
                MessageBox.Show("please select gender");
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
            if (ValidateForm())
            {
                Save();
                Saved = true;
                this.Close();
            }
        }
        private void consultButton_Click(object sender, EventArgs e)
        {
            VisitForm visit = new VisitForm();
            if(Visit != null)
            {
                visit.Visit = Visit;
                visit.Bill = Bill;
            }
            visit.ShowDialog(this);
            if(visit.Visit != null)
            {
                Visit = new VisitModel();
                Visit = visit.Visit;
                Bill = visit.Bill;
            }
        }

        private void PetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Visit != null && Saved == false)
            {
                var window = MessageBox.Show("Are you sure to end this session? all existing records will be deleted", "Are you sure?", MessageBoxButtons.YesNo);
                e.Cancel = (window == DialogResult.No);
            }
        }
    }
}
