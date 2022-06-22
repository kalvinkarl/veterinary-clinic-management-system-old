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
        private List<ClientModel> ClientAppointments { get; set; } = new List<ClientModel>();

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
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            if (listComboBox.Text == "All clients")
            {
                Clients = GlobalConfig.Connection.GetAllWithPetVisitsOfClients();
            }
            else if (listComboBox.Text == "Finished today")
            {
                Clients = GlobalConfig.Connection.GetTodayVisitsOfClients();
            }
            else if (listComboBox.Text == "Overdue/Late")
            {
                Clients = GlobalConfig.Connection.GetVisitsOfClients();
            }
            if (Clients.Count > 0)
            {
                foreach (ClientModel client in Clients)
                {
                    if (listComboBox.Text != "Overdue/Late")
                    {
                        dataGridView.Rows.Add(new string[] { client.Pets[0].ID.ToString(), client.FullName, client.Address, client.Cellphone, client.Pets[0].Name, client.Pets[0].Visits[0]?.NextVisit.ToString("g") });
                    }
                    else if(client.Pets[0].Visits[0]?.NextVisit.Date < DateTime.Now.Date && client.Pets[0].Visits[0]?.NextVisit != (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue)
                    {
                        dataGridView.Rows.Add(new string[] { client.Pets[0].ID.ToString(), client.FullName, client.Address, client.Cellphone, client.Pets[0].Name, client.Pets[0].Visits[0]?.NextVisit.ToString("g") });
                    }

                }
            }
        }
        private void BindAppGrid()
        {
            ClientAppointments = GlobalConfig.Connection.GetVisitsOfClients();
            appGridView.Rows.Clear();
            appGridView.Refresh();
            foreach (ClientModel client in ClientAppointments)
            {
                if (client.Pets[0].Visits[0]?.NextVisit.Date == appointmentDatePicker.Value.Date)
                {
                    appGridView.Rows.Add(new string[] { client.Pets[0].ID.ToString(), client.FullName, client.Address, client.Cellphone, client.Pets[0].Name, client.Pets[0].Visits[0]?.NextVisit.ToString("g") });
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
            MessageBox.Show(dataGridView.SelectedRows.Count.ToString());
            dataGridView.ClearSelection();
            appGridView.ClearSelection();
        }
        private void listComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDataGrid();
        }
        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            BindAppGrid();
        }
        private void developerStatus_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start(@"https:\\www.facebook.com\kalvinkarl28"); }
        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            appGridView.ClearSelection();
        }

        private void appGridView_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView.ClearSelection();
        }

        private void appGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(appGridView.SelectedRows.Count > 0)
            {
                string index = appGridView.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(index);
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                string index = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show(index);
            }
        }
    }
}
