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
    public partial class LandingForm : Form
    {
        private List<ClientModel> Clients { get; set; } = new List<ClientModel>();
        private List<ClientModel> clientAppointments { get; set; } = new List<ClientModel>();
        private void developerStatus_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start(@"https:\\www.facebook.com\kalvinkarl28"); }
        public LandingForm()
        {
            InitializeComponent();
            DefaultSizeResolution();
            appointmentDatePicker.Value = DateTime.Now;
        }
        private void DefaultSizeResolution()
        {
            if (Properties.Settings.Default.Size.Width == 0) Properties.Settings.Default.Upgrade();
            if (Properties.Settings.Default.Size.Width == 0 || Properties.Settings.Default.Size.Height == 0)
            {
                this.Size = new Size(1374, 749);
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(100, 70);
            }
            else
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                this.WindowState = Properties.Settings.Default.State;
                this.Location = Properties.Settings.Default.Location;
                this.Size = Properties.Settings.Default.Size;
                listComboBox.Text = Properties.Settings.Default.ClientListComboBox;
            }
        }
        private void SaveSizeRosolution()
        {
            Properties.Settings.Default.State = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Location = this.Location;
                Properties.Settings.Default.Size = this.Size;
            }
            else
            {
                Properties.Settings.Default.Location = this.RestoreBounds.Location;
                Properties.Settings.Default.Size = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.ClientListComboBox = listComboBox.Text;
            Properties.Settings.Default.Save();
        }
        private void BindDataGrid()
        {
            string nextVisit;
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            if (listComboBox.Text == "All clients")
            {
                Clients = GlobalConfig.Connection.GetAllWithVisitOfClients();
            }
            else if (listComboBox.Text == "Finished today")
            {
                Clients = GlobalConfig.Connection.GetTodayVisitsOfClients();
            }
            if (Clients.Count > 0)
            {
                foreach (ClientModel client in Clients)
                {
                    nextVisit = "No Appointments";
                    if (client.NextVisit >= (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue)
                    {
                        nextVisit = client.NextVisit.ToString("g");
                    }
                    dataGridView.Rows.Add(new string[] { client.FullName, client.Address, client.Cellphone, client.PetName, nextVisit });
                }
            }
        }
        private void BindAppGrid()
        {
            clientAppointments = GlobalConfig.Connection.GetVisitsOfClients();
            appGridView.Rows.Clear();
            appGridView.Refresh();
            foreach (ClientModel client in clientAppointments)
            {
                if (client.NextVisit.Date == appointmentDatePicker.Value.Date)
                {
                    appGridView.Rows.Add(new string[] { client.FullName, client.Address, client.Cellphone, client.PetName, client.NextVisit.ToString("g") });
                }
            }
        }
        private void newVisitorButton_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
            if (clientForm.Saved)
            {
                BindDataGrid();
                BindAppGrid();
            }
        }
        private void LandingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSizeRosolution();
        }
        private void timToday_Tick(object sender, EventArgs e)
        {
            timeStatus.Text = DateTime.Now.ToString();
        }
        private void addVisitButton_Click(object sender, EventArgs e)
        {
            if (landingTabs.SelectedIndex > 0)
            {
                //MessageBox.Show(mainTab.SelectedIndex.ToString());
                VisitForm visitForm = new VisitForm();
                visitForm.ShowDialog();
            }
            else
            {
                if (appGridView.SelectedRows.Count > 0)
                {
                    //OpenVisitForm(name);
                    VisitForm visitForm = new VisitForm();
                    //visitForm.Text += $" ({Clients[aptByDateList.SelectedIndices[0]].FullName})";
                    visitForm.ShowDialog();

                }
                else if (dataGridView.SelectedRows.Count > 0)
                {
                    //OpenVisitForm(name);
                    VisitForm visitForm = new VisitForm();
                    //visitForm.Text += $" ({Clients[aptByOtherList.SelectedIndices[0]].FullName})";
                    visitForm.ShowDialog();
                }
                else
                { 
                    MessageBox.Show("Please select a client.");
                }
            }
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            //ClientModel client = (ClientModel)dataGridView.CurrentRow.DataBoundItem;
            //MessageBox.Show($"{client.FullName}");
            DateTime md = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            MessageBox.Show(md.ToString());

        }
        private void listComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDataGrid();
        }
        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            BindAppGrid();
        }
    }
}
