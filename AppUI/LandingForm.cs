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
        private void developerStatus_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start(@"https:\\www.facebook.com\kalvinkarl28"); }
        public LandingForm()
        {
            InitializeComponent();
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

        private void newVisitorButton_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }
    }
}
