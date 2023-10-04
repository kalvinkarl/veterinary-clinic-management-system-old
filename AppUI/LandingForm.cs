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
        private int Themes { get; set; }
        public LandingForm()
        {
            InitializeComponent();
            DefaultSizeResolution();
            appointmentDatePicker.Value = DateTime.Now;
        }
        public void CloseCurrentTab()
        {
            landingTabs.TabPages.Remove(landingTabs.SelectedTab);
            landingTabs.SelectedIndex = landingTabs.TabCount - 1;
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
                Themes = Properties.Settings.Default.themes;
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
            Properties.Settings.Default.themes = Themes;
            Properties.Settings.Default.Save();
        }
        private int SwitchTheme()
        {
            if (Themes == 1)
            {
                GlobalConfig.IsDark = true;
                GlobalConfig.UseImmersiveDarkMode(Handle, GlobalConfig.IsDark);
                this.BackColor = Color.FromArgb(31, 31, 31);
                landingTabs.TabPages[0].BackColor = Color.FromArgb(31, 31, 31);
                statusStrip.BackColor = Color.FromArgb(31, 31, 31);
                menuStrip.BackColor = Color.FromArgb(31, 31, 31);
                adminStatus.ForeColor = Color.White;
                clientsSatus.ForeColor = Color.White;
                appointmentsSatus.ForeColor = Color.White;
                contactStatus.ForeColor = Color.White;
                timeStatus.ForeColor = Color.White;
                menuStrip.ForeColor = Color.White;
                dateLabel.ForeColor = Color.White;
                //listComboBox normalmode
                listComboBox.BackColor = Color.FromArgb(31, 31, 31);
                listComboBox.ForeColor = Color.White;
                //appGridView darkmode (Appointment datagrid view)
                appGridView.BackgroundColor = Color.FromArgb(31, 31, 31);
                appGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
                appGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
                appGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 54, 54);
                appGridView.DefaultCellStyle.BackColor = Color.FromArgb(31, 31, 31);
                appGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
                appGridView.DefaultCellStyle.ForeColor = Color.White;
                appGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                //dataGridView darkmode (default datagrid view)
                dataGridView.BackgroundColor = Color.FromArgb(31, 31, 31);
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(54, 54, 54);
                dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(31, 31, 31);
                dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
                dataGridView.DefaultCellStyle.ForeColor = Color.White;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.Refresh();
                return 1;
            }
            else
            {
                GlobalConfig.IsDark = false;
                GlobalConfig.UseImmersiveDarkMode(Handle, GlobalConfig.IsDark);
                this.BackColor = Color.White;
                landingTabs.TabPages[0].BackColor = Color.White;
                menuStrip.BackColor = Color.White;
                menuStrip.ForeColor = Color.Black;
                statusStrip.BackColor = Color.White;
                adminStatus.ForeColor = Color.Black;
                clientsSatus.ForeColor = Color.Black;
                appointmentsSatus.ForeColor = Color.Black;
                contactStatus.ForeColor = Color.Black;
                timeStatus.ForeColor = Color.Black;
                dateLabel.ForeColor = Color.Black;
                //listComboBox normalmode
                listComboBox.BackColor = Color.White;
                listComboBox.ForeColor = Color.Black;
                //appGridView normalmode (Appointment datagrid view)
                appGridView.BackgroundColor = Color.White;
                appGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                appGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                appGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                appGridView.DefaultCellStyle.BackColor = Color.White;
                appGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                appGridView.DefaultCellStyle.ForeColor = Color.Black;
                appGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                //dataGridView normalmode (default datagrid view)
                dataGridView.BackgroundColor = Color.White;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dataGridView.DefaultCellStyle.BackColor = Color.White;
                dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                dataGridView.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                this.Refresh();
                return 0;
            }
        }


        private void BindDataGrid()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            if (listComboBox.Text == "All client visits")
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
                    string nextVisit=null;
                    if (client.Pets[0].Visits[0]?.NextVisit.Date != System.Data.SqlTypes.SqlDateTime.MaxValue.Value.Date )
                    {
                        nextVisit = client.Pets[0].Visits[0]?.NextVisit.ToString("g");
                    }
                    if (listComboBox.Text == "All client visits" && client.Pets[0].VisitsCount == 1)
                    {
                        dataGridView.Rows.Add(new string[] { client.ID.ToString(), client.FullName, client.Address, client.Cellphone, client.Pets[0].Name, nextVisit });
                    }
                    else if (listComboBox.Text == "Finished today")
                    {
                        dataGridView.Rows.Add(new string[] { client.ID.ToString(), client.FullName, client.Address, client.Cellphone, client.Pets[0].Name, nextVisit });
                    }
                    else if(listComboBox.Text == "Overdue/Late" && client.Pets[0].Visits[0]?.NextVisit < DateTime.Now && client.Pets[0].VisitsCount == 1)
                    {
                        dataGridView.Rows.Add(new string[] { client.ID.ToString(), client.FullName, client.Address, client.Cellphone, client.Pets[0].Name, nextVisit });
                    }
                    dataGridView.ClearSelection();
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
                if (client.Pets[0].Visits[0]?.NextVisit.Date == appointmentDatePicker.Value.Date && client.Pets[0].VisitsCount == 1)
                {
                    appGridView.Rows.Add(new string[] { client.ID.ToString(), client.FullName, client.Address, client.Cellphone, client.Pets[0].Name, client.Pets[0].Visits[0]?.NextVisit.ToString("g") });
                    appGridView.ClearSelection();
                }
            }
        }
        private void OpenVisitsForm(ClientModel client)
        {
            VisitsForm visitsForm = new VisitsForm(this) { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill, Text = Name };
            TabPage visitTab = new TabPage(Name = client.FullName) { Visible = true };
            landingTabs.TabPages.Add(visitTab);
            visitTab.Controls.Add(visitsForm);
            landingTabs.SelectedIndex = landingTabs.TabCount - 1;
            visitsForm.Client = client;
            visitsForm.Show();
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
                int clientID = int.Parse(appGridView.SelectedRows[0].Cells[0].Value.ToString());
                OpenVisitsForm(ClientAppointments.Where(c => c.ID == clientID).First());
            }
        }
        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                int clientID = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                OpenVisitsForm(Clients.Where(c => c.ID == clientID).First());
            }
        }
        private void addVisitButton_Click(object sender, EventArgs e)
        {
            string title = "";
            int ClientID = 0;
            ClientModel model = new ClientModel();
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
                    title = $" - { appGridView.SelectedRows[0].Cells[1].Value }({appGridView.SelectedRows[0].Cells[4].Value })";
                    ClientID = int.Parse(appGridView.SelectedRows[0].Cells[0].Value.ToString());
                    model = ClientAppointments.Where(c => c.ID == ClientID).First();
                }
                else if(dataGridView.SelectedRows.Count > 0)
                {
                    title = $" - { dataGridView.SelectedRows[0].Cells[1].Value }({dataGridView.SelectedRows[0].Cells[4].Value })";
                    ClientID = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    model = Clients.Where(c => c.ID == ClientID).First();
                }
                if (appGridView.SelectedRows.Count > 0 || dataGridView.SelectedRows.Count > 0)
                {
                    VisitForm visitForm = new VisitForm();
                    visitForm.Text += title;
                    visitForm.ShowDialog();
                    if (visitForm.Saved)
                    {
                        visitForm.Visit.PetID = model.Pets[0].ID;
                        VisitModel v = GlobalConfig.Connection.CreateVisit(visitForm.Visit);
                        visitForm.Visit.Bill.VisitID = v.ID;
                        BillModel b = GlobalConfig.Connection.CreateBill(visitForm.Visit.Bill);
                        BindDataGrid();
                        BindAppGrid();
                        OpenVisitsForm(model);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a client.");
                }
            }
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
            appGridView.ClearSelection();
            dataGridView.ClearSelection();
            appGridView.DefaultCellStyle.Font = new Font("Gadugi", 12, FontStyle.Regular);
            dataGridView.DefaultCellStyle.Font = new Font("Gadugi", 12, FontStyle.Regular);
            SwitchTheme();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themes = 0;
            SwitchTheme();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themes = 1;
            SwitchTheme();
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themes = 2;
            SwitchTheme();
        }
    }
}
