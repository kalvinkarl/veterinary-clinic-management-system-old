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
    public partial class VisitForm : Form
    {
        public bool Saved { get; set; }
        private Dictionary<string, int> WeightUnits { get; set; } = new Dictionary<string, int> { ["kg"] = 0, ["hg"] = 1, ["dag"] = 2, ["g"] = 3 };
        private Dictionary<string, int> TempUnits { get; set; } = new Dictionary<string, int> { ["°C"] = 0, ["°F"] = 1 };
        public List<TemplateModel> Templates { get; set; } = new List<TemplateModel>();
        private string category { get; set; }
        public VisitModel Visit { get; set; }
        public VisitForm()
        {
            InitializeComponent();
            GlobalConfig.UseImmersiveDarkMode(Handle, GlobalConfig.IsDark);
            if (GlobalConfig.IsDark)
            {
                this.BackColor = Color.FromArgb(31, 31, 31);
                date.ForeColor = Color.White;
                dateLabel.ForeColor = Color.White;
                weightLabel.ForeColor = Color.White;
                tempLabel.ForeColor = Color.White;
                comDiagLabel.ForeColor = Color.White;
                treatLabel.ForeColor = Color.White;
                noteLabel.ForeColor = Color.White;
                appGroup.ForeColor = Color.White;
                appDateLabel.ForeColor = Color.White;
                appTime.ForeColor = Color.White;
                appHour.ForeColor = Color.FromArgb(64, 64, 64);
                appHour.BorderStyle = BorderStyle.FixedSingle;
                appHour.ForeColor = Color.White;
                appMinute.ForeColor = Color.FromArgb(64, 64, 64);
                appMinute.BorderStyle = BorderStyle.FixedSingle;
                appMinute.ForeColor = Color.White;
                ampm.ForeColor = Color.White;
                compDiagAttach.ForeColor = Color.White;
                treatmentAttach.ForeColor = Color.White;
                notesAttach.ForeColor = Color.White;
                weightUnit.BackColor = Color.FromArgb(31, 31, 31);
                tempUnit.BackColor = Color.FromArgb(31, 31, 31);
                weightUnit.ForeColor = Color.White;
                tempUnit.ForeColor = Color.White;
                weight.BackColor = Color.FromArgb(64, 64, 64);
                weight.BorderStyle = BorderStyle.FixedSingle;
                weight.ForeColor = Color.White;
                temp.BackColor = Color.FromArgb(64, 64, 64);
                temp.BorderStyle = BorderStyle.FixedSingle;
                temp.ForeColor = Color.White;
                complaintDiagnosis.BackColor = Color.FromArgb(64,64,64);
                complaintDiagnosis.BorderStyle = BorderStyle.FixedSingle;
                complaintDiagnosis.ForeColor = Color.White;
                treatment.BackColor = Color.FromArgb(64, 64, 64);
                treatment.BorderStyle = BorderStyle.FixedSingle;
                treatment.ForeColor = Color.White;
                notes.BackColor = Color.FromArgb(64, 64, 64);
                notes.BorderStyle = BorderStyle.FixedSingle;
                notes.ForeColor = Color.White;
            }
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
                if(Visit != null)
                {
                    paymentForm.Bill = Visit.Bill;
                }
                paymentForm.ShowDialog(this);
                if (paymentForm.Saved)
                {
                    Visit = new VisitModel();
                    Visit.Bill = paymentForm.Bill;
                    Visit.Weight = $"{weight.Text} {weightUnit.Text}";
                    Visit.Temperature = $"{temp.Text} {tempUnit.Text}";
                    Visit.ComplaintDiagnosis = complaintDiagnosis.Text;
                    Visit.Treatment = treatment.Text;
                    Visit.Notes = notes.Text;
                    Visit.Date = DateTime.Now;
                    if (appGroup.Visible)
                    {
                        Visit.NextVisit = DateTime.Parse($"{DateTime.Parse(appDate.Text).ToString("yyyy-MM-dd")} {DateTime.Parse($"{appHour.Value}:{appMinute.Value} {ampm.Text}").ToString("HH:mm")}");
                    }
                    else
                    {
                        Visit.NextVisit = (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue;
                    }
                    Visit.Bill = new BillModel();
                    Visit.Bill =paymentForm.Bill;
                    Saved = true;
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
            appOpen.Visible = !appOpen.Visible;
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
                date.Text = Visit.Date.ToString("dddd   ,   MMMM   dd   ,   yyyy");
                weight.Value = decimal.Parse(w[0]);
                weightUnit.SelectedIndex = WeightUnits[w[1]];
                temp.Value = decimal.Parse(t[0]);
                tempUnit.SelectedIndex = TempUnits[t[1]];
                complaintDiagnosis.Text = Visit.ComplaintDiagnosis;
                treatment.Text = Visit.Treatment;
                notes.Text = Visit.Notes;
                if(Visit.NextVisit != DateTime.MinValue)
                {
                    appGroup.Visible = true;
                    appDate.Value = Visit.NextVisit.Date;
                    appHour.Value = int.Parse(Visit.NextVisit.ToString("hh"));
                    appMinute.Value = Visit.NextVisit.Minute;
                    ampm.Text = Visit.NextVisit.ToString("tt");
                }
            }
            else
            {
                date.Text = DateTime.Now.ToString("dddd   ,   MMMM   dd   ,   yyyy");
                appDate.Value = DateTime.Now.AddDays(1);
                tempUnit.SelectedIndex = 0;
                weightUnit.SelectedIndex = 0;
            }
            LoadTemplates();
        }











        //Templates:
        private int Index(ToolStripItem Menu)
        {
            return (Menu).Owner.Items.IndexOf(Menu) - 1;
        }
        private void LoadTemplates()
        {
            templatesContextMenu.Items.Clear();
            templatesContextMenu.Items.Add("New Template", null, NewTemplate_Click);
            Templates = GlobalConfig.Connection.GetTemplatesByCategory(category);
            foreach (TemplateModel template in Templates)
            {
                ToolStripMenuItem MainMenu = (ToolStripMenuItem)templatesContextMenu.Items.Add($"{template.Title}", null, TempMenuItem_Click);
                MainMenu.DropDownItems.Add("Edit", null, TempEditItem_Click);
                MainMenu.DropDownItems.Add("Delete", null, TempDeleteItem_Click);
                templatesContextMenu.Items.Add(MainMenu);
            }
        }
        private void complaintDiagnosis_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                category = "ComplaintDiagnosis";
                LoadTemplates();
                templatesContextMenu.Show(Cursor.Position);
            }
        }
        private void treatment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                category = "Treatments";
                LoadTemplates();
                templatesContextMenu.Show(Cursor.Position);
            }
        }
        private void notes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                category = "VisitNotes";
                LoadTemplates();
                templatesContextMenu.Show(Cursor.Position);
            }
        }

        private void NewTemplate_Click(object sender, EventArgs e)
        {
            TemplateForm templateForm = new TemplateForm();
            templateForm.Category = category;
            templateForm.ShowDialog();
            if (templateForm.Saved)
            {
                LoadTemplates();
            }
        }
        private void TempMenuItem_Click(object sender, EventArgs e)
        {
            int i = Index((ToolStripItem)sender);
            if (category == "ComplaintDiagnosis")
            {
                complaintDiagnosis.Text += Templates[i].Template;
                complaintDiagnosis.Select(complaintDiagnosis.Text.Length, 0);
            }
            templatesContextMenu.Hide();
        }
        private void TempEditItem_Click(object sender, EventArgs e)
        {
            int i = Index(((ToolStripItem)sender).OwnerItem);
            TemplateForm templateForm = new TemplateForm();
            templateForm.Template = Templates[i];
            templateForm.ShowDialog();
            LoadTemplates();
        }
        private void TempDeleteItem_Click(object sender, EventArgs e)
        {
            int i = Index(((ToolStripItem)sender).OwnerItem);
            var msg = MessageBox.Show($"Are you sure to delete {Templates[i].Title} template?", $"Delete {Templates[i].Title}", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (msg == DialogResult.OK)
            {
                GlobalConfig.Connection.DeleteTemplate(Templates[i]);
                LoadTemplates();
            }
        }
    }
}
