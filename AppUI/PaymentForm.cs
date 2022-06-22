using AppLibrary;
using AppLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class PaymentForm : Form
    {
        public bool Saved { get; set; }
        public bool PayLater { get; set; }
        public BillModel Bill { get; set; }
        private Bitmap ImgMemmory { get; set; }
        public PaymentForm()
        {
            InitializeComponent();
            GlobalConfig.UseImmersiveDarkMode(Handle, GlobalConfig.IsDark);
            if (GlobalConfig.IsDark)
            {
                paymentPanel.BackColor = Color.FromArgb(31, 31, 31);
                oldBalance.ForeColor = Color.White;
                oldBalance.BackColor = Color.FromArgb(31, 31, 31);
                balance.ForeColor = Color.White;
                balance.BackColor = Color.FromArgb(31, 31, 31);
                oldBalanceLabel.ForeColor = Color.White;
                oldBalanceLabel.BackColor = Color.FromArgb(31, 31, 31);
                dueLabel.ForeColor = Color.White;
                dueLabel.BackColor = Color.FromArgb(31, 31, 31);
                paidLabel.ForeColor = Color.White;
                paidLabel.BackColor = Color.FromArgb(31, 31, 31);
                balanceLabel.ForeColor = Color.White;
                balanceLabel.BackColor = Color.FromArgb(31, 31, 31);
                due.BackColor = Color.FromArgb(64,64,64);
                due.BorderStyle = BorderStyle.FixedSingle;
                due.ForeColor = Color.White;
                paid.BackColor = Color.FromArgb(64,64,64);
                paid.BorderStyle = BorderStyle.FixedSingle;
                paid.ForeColor = Color.White;
                doneButton.BackColor = Color.FromArgb(64,64,64);
                doneButton.FlatStyle = FlatStyle.Flat;
                doneButton.ForeColor = Color.White;

            }
        }
        private void PrintPanel(Panel panel)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            printBillsPanel = panel;
            ImgMemmory = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(ImgMemmory, new Rectangle(0, 0, panel.Width, panel.Height));
            printBills.PrintPage += new PrintPageEventHandler(printBills_PrintPage);
            previewBills.Document = printBills;
            ((Form)previewBills).Size = new Size(700, 900);
            ((Form)previewBills).StartPosition = FormStartPosition.CenterParent;
            previewBills.ShowDialog();
        }
        private void printBills_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle PageArea = e.PageBounds;
            e.Graphics.DrawImage(ImgMemmory, (PageArea.Width / 2) - ((printBillsPanel.Width + 40) / 2), printBillsPanel.Location.Y);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            printBillsPanel.Location = new Point(-780, 0);
            due.Select();
            if (PayLater)
            {
                paid.Visible = false;
                paidLabel.Visible = false;
                balance.Visible = false;
                balanceLabel.Visible = false;
                doneButton.Top = doneButton.Top - 60;
                this.MinimumSize = new Size(232, 213);
                this.Size = new Size(342, 213);
                doneButton.Text = "Save";
            }
            if (Bill != null)
            {
                due.Text = Bill.TotalAmount.ToString();
                paid.Text = Bill.PaidAmount.ToString();
            }
        }
        private void doneButton_Click(object sender, EventArgs e)
        {
            Bill = new BillModel();
            Bill.InvoiceNumber = 987654321;
            Bill.TotalAmount = decimal.Parse(due.Text);
            Bill.Date = DateTime.Now;
            if (PayLater)
            {
                Bill.PaidAmount = 0;
            }
            else
            {
                Bill.PaidAmount = decimal.Parse(paid.Text);
                PrintPanel(printBillsPanel);
            }
            Saved = true;
            this.Close();
        }
    }
}
