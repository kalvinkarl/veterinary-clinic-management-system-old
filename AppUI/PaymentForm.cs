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
        private Bitmap ImgMemmory;
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
            oldBal.ForeColor = Color.Black;
            printBillsPanel.Location = new Point(-780, 0);
            due.Select();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPanel(printBillsPanel);
        }
    }
}
