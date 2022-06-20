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
        public BillModel Bill { get; set; }
        public bool PayLater { get; set; }
        private Bitmap ImgMemmory { get; set; }
        public PaymentForm()
        {
            InitializeComponent();
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
            oldBalance.ForeColor = Color.Black;
            printBillsPanel.Location = new Point(-780, 0);
            due.Select();
            if (PayLater)
            {
                paid.Visible = false;
                paidLabel.Visible = false;
                balance.Visible = false;
                balanceLabel.Visible = false;
                btnDone.Top = btnDone.Top - 60;
                this.MinimumSize = new Size(232, 213);
                this.Size = new Size(342, 213);
                btnDone.Text = "Save";
            }
            if (Bill != null)
            {
                due.Text = Bill.TotalAmount.ToString();
                paid.Text = Bill.PaidAmount.ToString();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
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
            this.Close();

        }
    }
}
