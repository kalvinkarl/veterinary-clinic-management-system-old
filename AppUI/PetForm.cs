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
        public bool Saved { get; set; }
        public PetModel Pet { get; set; }
        public PetForm()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            if (name.Text == string.Empty)
            {
                MessageBox.Show("Invalid name");
                return false;
            }
            else if (species.Text == string.Empty)
            {
                MessageBox.Show("Invalid species");
                return false;
            }
            else if (breed.Text == string.Empty)
            {
                MessageBox.Show("Invalid breed");
                return false;
            }
            else if (colorMarking.Text == string.Empty)
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
                //TODO - add visit
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
                Pet = new PetModel();
                Pet.Name = name.Text;
                Pet.Species = species.Text;
                Pet.Breed = breed.Text;
                Pet.ColorMarking = colorMarking.Text;
                Pet.Age = int.Parse(age.Text);
                Pet.Sex = getSex();
                Pet.Notes = notes.Text;
                //TODO - add visits
                Saved = true;
                this.Close();
            }
        }
        public static int getVisitFromDialog(List<VisitModel> visits)
        {
            Form form = new Form();
            form.Font = new Font("Gadugi", 12);
            form.Width = 220;
            form.Height = 100;
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.None;
            Label label = new Label() { Left = 10, Top = 5, Text = "Select visit date" };
            ComboBox comboBox = new ComboBox() { Top = 30, Left = 10, Width = 200 };
            comboBox.Items.Add("[Select]");
            foreach(VisitModel visit in visits)
            {
                comboBox.Items.Add(visit.ComplaintDiagnosis);
            }
            comboBox.SelectedIndex = 0;
            Button okButton = new Button() { Top = 65, Left = 10, Width = 200, Text = "Ok", Height = 27 };
            okButton.Click += (sender, e) => { form.Close(); };
            form.Controls.Add(label);
            form.Controls.Add(comboBox);
            form.Controls.Add(okButton);
            form.ShowDialog();
            return comboBox.SelectedIndex;
        }
        private void consultButton_Click(object sender, EventArgs e)
        {
            VisitForm visit = new VisitForm();
            if(Pet is null)
            {
                visit.ShowDialog(this);
                if (visit.Visit != null)
                {
                    Pet = new PetModel();
                    Pet.Visits.Add(visit.Visit);
                    
                }
            }
            else
            {
                var AddOrEdit = MessageBox.Show($"Consult is already exist.\nPRESS [Yes] to Edit previous.\nPRESS [No] to Add new.\nCancel to do nothing.", "Do you want to edit? or add?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (AddOrEdit == DialogResult.Yes)
                {
                    int visitIndex = getVisitFromDialog(Pet.Visits);
                    if(visitIndex != 0)
                    {
                        visit.Visit = Pet.Visits[visitIndex-1];
                        visit.ShowDialog(this);
                        Pet.Visits[visitIndex-1] = visit.Visit;
                    }
                }else if (AddOrEdit == DialogResult.No)
                {
                    visit.ShowDialog(this);
                    if (visit.Visit != null)
                    {
                        Pet.Visits.Add(visit.Visit);
                    }
                }
            }
        }
        private void PetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Pet != null && Saved == false)
            {
                var window = MessageBox.Show("Are you sure to end this session? all existing records will be deleted", "Are you sure?", MessageBoxButtons.YesNo);
                e.Cancel = (window == DialogResult.No);
            }
        }
    }
}
