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
        public PetModel Pet { get; set; } = new PetModel();
        public PetForm()
        {
            InitializeComponent();
        }
        public static int getEditVisitFromDialog(List<VisitModel> visits)
        {
            int visitIndex = -2;
            Form form = new Form();
            form.Font = new Font("Gadugi", 12);
            form.Width = 237;
            form.Height = 140;
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            Label label = new Label() { Left = 10, Top = 5, Text = "Select visit date" };
            ComboBox comboBox = new ComboBox() { Top = 30, Left = 10, Width = 200 };
            foreach (VisitModel visit in visits)
            {
                comboBox.Items.Add(visit.ComplaintDiagnosis);
            }
            comboBox.SelectedIndex = 0;
            Button okButton = new Button() { Top = 65, Left = 10, Width = 65, Text = "Ok", Height = 27 };
            Button addButton = new Button() { Top = 65, Left = 77, Width = 65, Text = "Add", Height = 27 };
            Button cancelButton = new Button() { Top = 65, Left = 144, Width = 65, Text = "Cancel", Height = 27 };
            okButton.Click += (sender, e) => {
                visitIndex = comboBox.SelectedIndex;
                form.Close();
            };
            addButton.Click += (sender, e) => {
                visitIndex = -1;
                form.Close();
            };
            cancelButton.Click += (sender, e) => {
                form.Close();
            };
            form.Controls.Add(label);
            form.Controls.Add(comboBox);
            form.Controls.Add(okButton);
            form.Controls.Add(addButton);
            form.Controls.Add(cancelButton);
            form.ShowDialog();
            return visitIndex;
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
                Pet.Name = name.Text;
                Pet.Species = species.Text;
                Pet.Breed = breed.Text;
                Pet.ColorMarking = colorMarking.Text;
                Pet.Age = int.Parse(age.Text);
                Pet.Sex = getSex();
                Pet.Notes = notes.Text;
                Saved = true;
                this.Close();
            }
        }
        private void consultButton_Click(object sender, EventArgs e)
        {
            VisitForm visit = new VisitForm();
            if(Pet.Visits.Count > 0)
            {
                int visitIndex = getEditVisitFromDialog(Pet.Visits);
                if (visitIndex >= 0)
                {
                    visit.Visit = Pet.Visits[visitIndex];
                    visit.ShowDialog(this);
                    Pet.Visits[visitIndex] = visit.Visit;
                }
                else if (visitIndex == -1)
                {
                    visit.ShowDialog(this);
                    if (visit.Visit != null)
                    {
                        Pet.Visits.Add(visit.Visit);
                    }
                }
            }
            else
            {
                visit.ShowDialog(this);
                if (visit.Visit != null)
                {
                    Pet = new PetModel();
                    Pet.Visits.Add(visit.Visit);
                    
                }
            }
        }
        private void PetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Pet.Visits.Count > 0 && Saved == false)
            {
                var window = MessageBox.Show("Are you sure to end this session? all existing records will be deleted", "Are you sure?", MessageBoxButtons.YesNo);
                e.Cancel = (window == DialogResult.No);
            }
        }
    }
}
