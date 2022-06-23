namespace AppUI
{
    partial class TemplateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.templatesMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.addTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.tempTitle = new System.Windows.Forms.Label();
            this.template = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templatesMenu});
            this.statusStrip1.Location = new System.Drawing.Point(-1, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(389, 31);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            // 
            // templatesMenu
            // 
            this.templatesMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.templatesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTemplate,
            this.deleteTemplate});
            this.templatesMenu.Image = ((System.Drawing.Image)(resources.GetObject("templatesMenu.Image")));
            this.templatesMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.templatesMenu.Name = "templatesMenu";
            this.templatesMenu.Size = new System.Drawing.Size(93, 29);
            this.templatesMenu.Text = "Templates";
            // 
            // addTemplate
            // 
            this.addTemplate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTemplate.Image = ((System.Drawing.Image)(resources.GetObject("addTemplate.Image")));
            this.addTemplate.Name = "addTemplate";
            this.addTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.addTemplate.Size = new System.Drawing.Size(185, 22);
            this.addTemplate.Text = "Save Temp";
            this.addTemplate.Click += new System.EventHandler(this.addTemplate_Click);
            // 
            // deleteTemplate
            // 
            this.deleteTemplate.Enabled = false;
            this.deleteTemplate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTemplate.Image = ((System.Drawing.Image)(resources.GetObject("deleteTemplate.Image")));
            this.deleteTemplate.Name = "deleteTemplate";
            this.deleteTemplate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteTemplate.Size = new System.Drawing.Size(185, 22);
            this.deleteTemplate.Text = "Delete Temp";
            this.deleteTemplate.Click += new System.EventHandler(this.deleteTemplate_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.close.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(339, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 28);
            this.close.TabIndex = 7;
            this.close.Text = "✕";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Location = new System.Drawing.Point(-1, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(389, 22);
            this.title.TabIndex = 9;
            this.title.Text = "Title";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Visible = false;
            this.title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.title_KeyDown);
            this.title.Leave += new System.EventHandler(this.title_Leave);
            // 
            // tempTitle
            // 
            this.tempTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tempTitle.Location = new System.Drawing.Point(-1, 0);
            this.tempTitle.Name = "tempTitle";
            this.tempTitle.Size = new System.Drawing.Size(390, 30);
            this.tempTitle.TabIndex = 6;
            this.tempTitle.Text = "Title";
            this.tempTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempTitle.DoubleClick += new System.EventHandler(this.tempTitle_DoubleClick);
            this.tempTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tempTitle_MouseDown);
            this.tempTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tempTitle_MouseMove);
            this.tempTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tempTitle_MouseUp);
            // 
            // template
            // 
            this.template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.template.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.template.Location = new System.Drawing.Point(3, 31);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(383, 208);
            this.template.TabIndex = 10;
            this.template.Text = "";
            this.template.WordWrap = false;
            this.template.KeyDown += new System.Windows.Forms.KeyEventHandler(this.template_KeyDown);
            this.template.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.template_KeyPress);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 275);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.template);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tempTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton templatesMenu;
        private System.Windows.Forms.ToolStripMenuItem addTemplate;
        private System.Windows.Forms.ToolStripMenuItem deleteTemplate;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label tempTitle;
        private System.Windows.Forms.RichTextBox template;
    }
}