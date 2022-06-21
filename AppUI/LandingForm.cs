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
        public List<ClientModel> Clients { get; set; } = new List<ClientModel>();
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
            MessageBox.Show(DateTime.MinValue.ToString());

        }

        private void listComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listComboBox.Text == "All clients")
            {
                Clients = GlobalConfig.Connection.GetAllClientPets();
                FormatDatagrid();
            }
            else if(listComboBox.Text == "Finished today")
            {
                Clients = GlobalConfig.Connection.GetByTodayClients();
                FormatDatagrid();
            }
        }
    }
}
