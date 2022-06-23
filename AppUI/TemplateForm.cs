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
    public partial class TemplateForm : Form
    {
        public bool Saved { get; set; }
        public string Category { get; set; }
        public TemplateModel Template { get; set; }
        public TemplateForm()
        {
            InitializeComponent();
        }
        //Start Shadow + Mouse Move for Borderless
        private bool Drag;
        private int MouseX;
        private int MouseY;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void tempTitle_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void tempTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void tempTitle_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }
        //End Shadow + Mouse Move for Borderless



        //Start codes:
        private void TemplateForm_Load(object sender, EventArgs e)
        {
            if (Template != null)
            {
                tempTitle.Text = Template.Title;
                title.Text = Template.Title;
                template.Text = Template.Template;
            }
        }
        private void OnMouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
            close.ForeColor = Color.White;
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(255, 224, 192);
            close.ForeColor = Color.FromArgb(32, 32, 32);
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool keydowncalled = false;
        private void template_KeyDown(object sender, KeyEventArgs e)
        {
            keydowncalled = false;
            if (e.KeyData == (Keys.Control | Keys.Enter))
            {
                keydowncalled = true;
                SaveTemplate();
            }
            if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.Escape))
                this.Close();
        }
        private void template_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keydowncalled == true)
                e.Handled = true;
        }
        private void title_Leave(object sender, EventArgs e)
        {
            tempTitle.Text = title.Text;
            title.Visible = false;
        }
        private void title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyData == Keys.Enter)
            {
                template.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void tempTitle_DoubleClick(object sender, EventArgs e)
        {
            if (title.Visible == false)
            {
                title.Visible = true;
                title.SelectAll();
                title.Focus();
            }
        }
        private void addTemplate_Click(object sender, EventArgs e)
        {
            SaveTemplate();
        }
        private void SaveTemplate()
        {
            if (title.Text != "Title" && template.Text != "")
            {
                Template = new TemplateModel();
                Template.Category = Category;
                Template.Title = title.Text;
                Template.Template = template.Text;
                if (Template.ID >= 0)
                {
                    GlobalConfig.Connection.UpdateTemplate(Template);
                    MessageBox.Show($"Successfully update template {Template.Title}!");
                }
                else
                {
                    GlobalConfig.Connection.CreateTemplate(Template);
                    MessageBox.Show($"Successfully saved template {Template.Title}!");
                }
                Saved = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a Title and Details of the template before saving.");
            }
        }
    }
}
