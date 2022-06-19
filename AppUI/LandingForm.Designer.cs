namespace AppUI
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userManMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.accSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.backupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.themeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.licencedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.searchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1251, 25);
            this.menuStrip.TabIndex = 1;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManMenu,
            this.accSettingsMenu,
            this.toolStripSeparator1,
            this.backupMenu,
            this.restorMenu,
            this.exportMenu,
            this.toolStripSeparator2,
            this.printMenu,
            this.toolStripSeparator3,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 19);
            this.fileMenu.Text = "File";
            // 
            // userManMenu
            // 
            this.userManMenu.Image = ((System.Drawing.Image)(resources.GetObject("userManMenu.Image")));
            this.userManMenu.Name = "userManMenu";
            this.userManMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.userManMenu.Size = new System.Drawing.Size(245, 22);
            this.userManMenu.Text = "User Management";
            // 
            // accSettingsMenu
            // 
            this.accSettingsMenu.Image = ((System.Drawing.Image)(resources.GetObject("accSettingsMenu.Image")));
            this.accSettingsMenu.Name = "accSettingsMenu";
            this.accSettingsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.accSettingsMenu.Size = new System.Drawing.Size(245, 22);
            this.accSettingsMenu.Text = "Account Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // backupMenu
            // 
            this.backupMenu.Image = ((System.Drawing.Image)(resources.GetObject("backupMenu.Image")));
            this.backupMenu.Name = "backupMenu";
            this.backupMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.backupMenu.Size = new System.Drawing.Size(245, 22);
            this.backupMenu.Text = "Backup Data";
            // 
            // restorMenu
            // 
            this.restorMenu.Image = ((System.Drawing.Image)(resources.GetObject("restorMenu.Image")));
            this.restorMenu.Name = "restorMenu";
            this.restorMenu.Size = new System.Drawing.Size(245, 22);
            this.restorMenu.Text = "Restore";
            // 
            // exportMenu
            // 
            this.exportMenu.Image = ((System.Drawing.Image)(resources.GetObject("exportMenu.Image")));
            this.exportMenu.Name = "exportMenu";
            this.exportMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.exportMenu.Size = new System.Drawing.Size(245, 22);
            this.exportMenu.Text = "Export";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // printMenu
            // 
            this.printMenu.Image = ((System.Drawing.Image)(resources.GetObject("printMenu.Image")));
            this.printMenu.Name = "printMenu";
            this.printMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMenu.Size = new System.Drawing.Size(245, 22);
            this.printMenu.Text = "Print";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Image = ((System.Drawing.Image)(resources.GetObject("exitMenu.Image")));
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenu.Size = new System.Drawing.Size(245, 22);
            this.exitMenu.Text = "Exit";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenu,
            this.redoMenu,
            this.toolStripSeparator4,
            this.cutMenu,
            this.copyMenu,
            this.pasteMenu,
            this.deleteMenu,
            this.toolStripSeparator5,
            this.selectAllMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 19);
            this.editMenu.Text = "Edit";
            // 
            // undoMenu
            // 
            this.undoMenu.Image = ((System.Drawing.Image)(resources.GetObject("undoMenu.Image")));
            this.undoMenu.Name = "undoMenu";
            this.undoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenu.Size = new System.Drawing.Size(180, 22);
            this.undoMenu.Text = "Undo";
            // 
            // redoMenu
            // 
            this.redoMenu.Image = ((System.Drawing.Image)(resources.GetObject("redoMenu.Image")));
            this.redoMenu.Name = "redoMenu";
            this.redoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenu.Size = new System.Drawing.Size(180, 22);
            this.redoMenu.Text = "Redo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // cutMenu
            // 
            this.cutMenu.Image = ((System.Drawing.Image)(resources.GetObject("cutMenu.Image")));
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenu.Size = new System.Drawing.Size(180, 22);
            this.cutMenu.Text = "Cut";
            // 
            // copyMenu
            // 
            this.copyMenu.Image = ((System.Drawing.Image)(resources.GetObject("copyMenu.Image")));
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenu.Size = new System.Drawing.Size(180, 22);
            this.copyMenu.Text = "Copy";
            // 
            // pasteMenu
            // 
            this.pasteMenu.Image = ((System.Drawing.Image)(resources.GetObject("pasteMenu.Image")));
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenu.Size = new System.Drawing.Size(180, 22);
            this.pasteMenu.Text = "Paste";
            // 
            // deleteMenu
            // 
            this.deleteMenu.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenu.Image")));
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenu.Size = new System.Drawing.Size(180, 22);
            this.deleteMenu.Text = "Delete";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllMenu
            // 
            this.selectAllMenu.Image = ((System.Drawing.Image)(resources.GetObject("selectAllMenu.Image")));
            this.selectAllMenu.Name = "selectAllMenu";
            this.selectAllMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenu.Size = new System.Drawing.Size(180, 22);
            this.selectAllMenu.Text = "Select All";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeMenu,
            this.historyMenu,
            this.toolStripSeparator6,
            this.settingsMenu});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(46, 19);
            this.toolsMenu.Text = "Tools";
            // 
            // themeMenu
            // 
            this.themeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themeMenu.Image = ((System.Drawing.Image)(resources.GetObject("themeMenu.Image")));
            this.themeMenu.Name = "themeMenu";
            this.themeMenu.Size = new System.Drawing.Size(180, 22);
            this.themeMenu.Text = "Theme";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("defaultToolStripMenuItem.Image")));
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // historyMenu
            // 
            this.historyMenu.Image = ((System.Drawing.Image)(resources.GetObject("historyMenu.Image")));
            this.historyMenu.Name = "historyMenu";
            this.historyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.historyMenu.Size = new System.Drawing.Size(180, 22);
            this.historyMenu.Text = "History";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // settingsMenu
            // 
            this.settingsMenu.Image = ((System.Drawing.Image)(resources.GetObject("settingsMenu.Image")));
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.settingsMenu.Size = new System.Drawing.Size(180, 22);
            this.settingsMenu.Text = "Settings";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpMenu,
            this.licencedMenu,
            this.aboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemQuestion)));
            this.helpMenu.Size = new System.Drawing.Size(44, 19);
            this.helpMenu.Text = "Help";
            // 
            // viewHelpMenu
            // 
            this.viewHelpMenu.Image = ((System.Drawing.Image)(resources.GetObject("viewHelpMenu.Image")));
            this.viewHelpMenu.Name = "viewHelpMenu";
            this.viewHelpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.viewHelpMenu.Size = new System.Drawing.Size(180, 22);
            this.viewHelpMenu.Text = "View Help";
            // 
            // licencedMenu
            // 
            this.licencedMenu.Image = ((System.Drawing.Image)(resources.GetObject("licencedMenu.Image")));
            this.licencedMenu.Name = "licencedMenu";
            this.licencedMenu.Size = new System.Drawing.Size(180, 22);
            this.licencedMenu.Text = "Licenced";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Image = ((System.Drawing.Image)(resources.GetObject("aboutMenu.Image")));
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(180, 22);
            this.aboutMenu.Text = "About";
            // 
            // searchGroup
            // 
            this.searchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroup.Controls.Add(this.searchText);
            this.searchGroup.Controls.Add(this.searchBox);
            this.searchGroup.Location = new System.Drawing.Point(880, 0);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(371, 56);
            this.searchGroup.TabIndex = 6;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            this.searchGroup.Visible = false;
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(6, 21);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(226, 27);
            this.searchText.TabIndex = 7;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Items.AddRange(new object[] {
            "Name",
            "Pet",
            "Contact"});
            this.searchBox.Location = new System.Drawing.Point(238, 21);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 24);
            this.searchBox.TabIndex = 6;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 655);
            this.Controls.Add(this.searchGroup);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LandingForm";
            this.Text = "Veterinary Clinic Management System (Sniffs & Licks)";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem userManMenu;
        private System.Windows.Forms.ToolStripMenuItem accSettingsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem backupMenu;
        private System.Windows.Forms.ToolStripMenuItem restorMenu;
        private System.Windows.Forms.ToolStripMenuItem exportMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoMenu;
        private System.Windows.Forms.ToolStripMenuItem redoMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem themeMenu;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem viewHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem licencedMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ComboBox searchBox;
    }
}

