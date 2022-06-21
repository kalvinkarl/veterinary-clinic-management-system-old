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
        public List<ClientModel> Clients { get; set; } = GlobalConfig.InitializeClientRecords();
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
        private void FormatDatagrid()
        {
            if(Clients.Count > 0)
            {
                dataGridView.DataSource = Clients;
                dataGridView.Columns["ID"].Visible = false;
                dataGridView.Columns["Image"].Visible = false;
                dataGridView.Columns["FirstName"].Visible = false;
                dataGridView.Columns["LastName"].Visible = false;
                dataGridView.Columns["FullName"].DisplayIndex = 0;
                dataGridView.Columns["FullName"].Width = 200;
                dataGridView.Columns["Address"].DisplayIndex = 1;
                dataGridView.Columns["Address"].Width = 300;
                dataGridView.Columns["Cellphone"].DisplayIndex = 2;
                dataGridView.Columns["Cellphone"].Width = 130;
                dataGridView.Columns["DateRegistered"].DisplayIndex = 3;
                dataGridView.Columns["DateRegistered"].Width = 160;
            }
            else
            {
                dataGridView.DataSource = null;
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
            }
        }
        private void newVisitorButton_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
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

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show($"{  }");
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
            if (listComboBox.Text == "All clients")
            {
                FormatDatagrid();
            }
            else if(listComboBox.Text == "Finished today")
            {
                Clients = GlobalConfig.Connection.GetByTodayClients();
                FormatDatagrid();
            }
        }

        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {
            //Clients = GlobalConfig.Connection.GetByVisitDate(appointmentDatePicker.Value);
            List<ClientModel> clientModel = GlobalConfig.GetClientVisitsByDate(Clients,appointmentDatePicker.Value);
            if(clientModel .Count > 0)
            {
                appGridView.DataSource = clientModel;
                appGridView.Columns["ID"].Visible = false;
                appGridView.Columns["Image"].Visible = false;
                appGridView.Columns["FirstName"].Visible = false;
                appGridView.Columns["LastName"].Visible = false;
                appGridView.Columns["FullName"].DisplayIndex = 0;
                appGridView.Columns["FullName"].Width = 200;
                appGridView.Columns["Address"].DisplayIndex = 1;
                appGridView.Columns["Address"].Width = 300;
                appGridView.Columns["Cellphone"].DisplayIndex = 2;
                appGridView.Columns["Cellphone"].Width = 130;
                appGridView.Columns["DateRegistered"].DisplayIndex = 3;
                appGridView.Columns["DateRegistered"].Width = 160;
            }
            else
            {
                appGridView.DataSource = null;
                appGridView.Rows.Clear();
                appGridView.Refresh();
            }
        }
    }
}
