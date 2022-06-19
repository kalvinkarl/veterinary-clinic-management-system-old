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
        public PetModel Pet { get; set; } = new PetModel();
        public PetForm()
        {
            InitializeComponent();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            PetModel pet = new PetModel();
            pet.Name = name.Text;
            pet.Species = species.Text;
            pet.Breed = breed.Text;
            pet.ColorMarking = colorMarking.Text;
            pet.Age = int.Parse(age.Text);
            pet.Sex = getSex();
            pet.Notes = notes.Text;
            ClientForm form = (ClientForm)this.Owner;
            form.Pets.Add(pet);
            this.Close();
        }

        private void PetForm_Load(object sender, EventArgs e)
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
}
