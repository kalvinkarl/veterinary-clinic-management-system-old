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
            this.components = new System.ComponentModel.Container();
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
            this.landingTabs = new System.Windows.Forms.TabControl();
            this.appointmentsTab = new System.Windows.Forms.TabPage();
            this.aptLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.appGridView = new System.Windows.Forms.DataGridView();
            this.datePanel = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.listComboBox = new System.Windows.Forms.ComboBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.billsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.addVisitButton = new System.Windows.Forms.Button();
            this.newVisitorButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.developerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timToday = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.searchGroup.SuspendLayout();
            this.landingTabs.SuspendLayout();
            this.appointmentsTab.SuspendLayout();
            this.aptLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appGridView)).BeginInit();
            this.datePanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1609, 27);
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
            this.undoMenu.Size = new System.Drawing.Size(164, 22);
            this.undoMenu.Text = "Undo";
            // 
            // redoMenu
            // 
            this.redoMenu.Image = ((System.Drawing.Image)(resources.GetObject("redoMenu.Image")));
            this.redoMenu.Name = "redoMenu";
            this.redoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenu.Size = new System.Drawing.Size(164, 22);
            this.redoMenu.Text = "Redo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // cutMenu
            // 
            this.cutMenu.Image = ((System.Drawing.Image)(resources.GetObject("cutMenu.Image")));
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenu.Size = new System.Drawing.Size(164, 22);
            this.cutMenu.Text = "Cut";
            // 
            // copyMenu
            // 
            this.copyMenu.Image = ((System.Drawing.Image)(resources.GetObject("copyMenu.Image")));
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenu.Size = new System.Drawing.Size(164, 22);
            this.copyMenu.Text = "Copy";
            // 
            // pasteMenu
            // 
            this.pasteMenu.Image = ((System.Drawing.Image)(resources.GetObject("pasteMenu.Image")));
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenu.Size = new System.Drawing.Size(164, 22);
            this.pasteMenu.Text = "Paste";
            // 
            // deleteMenu
            // 
            this.deleteMenu.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenu.Image")));
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenu.Size = new System.Drawing.Size(164, 22);
            this.deleteMenu.Text = "Delete";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllMenu
            // 
            this.selectAllMenu.Image = ((System.Drawing.Image)(resources.GetObject("selectAllMenu.Image")));
            this.selectAllMenu.Name = "selectAllMenu";
            this.selectAllMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenu.Size = new System.Drawing.Size(164, 22);
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
            this.themeMenu.Size = new System.Drawing.Size(155, 22);
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
            this.historyMenu.Size = new System.Drawing.Size(155, 22);
            this.historyMenu.Text = "History";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(152, 6);
            // 
            // settingsMenu
            // 
            this.settingsMenu.Image = ((System.Drawing.Image)(resources.GetObject("settingsMenu.Image")));
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.settingsMenu.Size = new System.Drawing.Size(155, 22);
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
            this.viewHelpMenu.Size = new System.Drawing.Size(173, 22);
            this.viewHelpMenu.Text = "View Help";
            // 
            // licencedMenu
            // 
            this.licencedMenu.Image = ((System.Drawing.Image)(resources.GetObject("licencedMenu.Image")));
            this.licencedMenu.Name = "licencedMenu";
            this.licencedMenu.Size = new System.Drawing.Size(173, 22);
            this.licencedMenu.Text = "Licenced";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Image = ((System.Drawing.Image)(resources.GetObject("aboutMenu.Image")));
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(173, 22);
            this.aboutMenu.Text = "About";
            // 
            // searchGroup
            // 
            this.searchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroup.Controls.Add(this.searchText);
            this.searchGroup.Controls.Add(this.searchBox);
            this.searchGroup.Location = new System.Drawing.Point(1132, 0);
            this.searchGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGroup.Size = new System.Drawing.Size(477, 66);
            this.searchGroup.TabIndex = 6;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            this.searchGroup.Visible = false;
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(8, 25);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(290, 27);
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
            this.searchBox.Location = new System.Drawing.Point(306, 25);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(155, 27);
            this.searchBox.TabIndex = 6;
            // 
            // landingTabs
            // 
            this.landingTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.landingTabs.Controls.Add(this.appointmentsTab);
            this.landingTabs.Location = new System.Drawing.Point(0, 159);
            this.landingTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.landingTabs.Name = "landingTabs";
            this.landingTabs.SelectedIndex = 0;
            this.landingTabs.Size = new System.Drawing.Size(1609, 591);
            this.landingTabs.TabIndex = 7;
            // 
            // appointmentsTab
            // 
            this.appointmentsTab.Controls.Add(this.aptLayoutPanel);
            this.appointmentsTab.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsTab.Location = new System.Drawing.Point(4, 28);
            this.appointmentsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointmentsTab.Name = "appointmentsTab";
            this.appointmentsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointmentsTab.Size = new System.Drawing.Size(1601, 559);
            this.appointmentsTab.TabIndex = 0;
            this.appointmentsTab.Text = "Appointments";
            this.appointmentsTab.UseVisualStyleBackColor = true;
            // 
            // aptLayoutPanel
            // 
            this.aptLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aptLayoutPanel.BackColor = System.Drawing.Color.White;
            this.aptLayoutPanel.ColumnCount = 2;
            this.aptLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aptLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.aptLayoutPanel.Controls.Add(this.dataGridView, 1, 1);
            this.aptLayoutPanel.Controls.Add(this.appGridView, 0, 1);
            this.aptLayoutPanel.Controls.Add(this.datePanel, 0, 0);
            this.aptLayoutPanel.Controls.Add(this.listComboBox, 1, 0);
            this.aptLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.aptLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aptLayoutPanel.Name = "aptLayoutPanel";
            this.aptLayoutPanel.RowCount = 2;
            this.aptLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.aptLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.aptLayoutPanel.Size = new System.Drawing.Size(1599, 553);
            this.aptLayoutPanel.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeight = 27;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(802, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(794, 502);
            this.dataGridView.StandardTab = true;
            this.dataGridView.TabIndex = 14;
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            // 
            // appGridView
            // 
            this.appGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appGridView.BackgroundColor = System.Drawing.Color.White;
            this.appGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appGridView.Location = new System.Drawing.Point(3, 48);
            this.appGridView.Name = "appGridView";
            this.appGridView.Size = new System.Drawing.Size(793, 502);
            this.appGridView.TabIndex = 13;
            // 
            // datePanel
            // 
            this.datePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePanel.Controls.Add(this.dateLabel);
            this.datePanel.Controls.Add(this.appointmentDatePicker);
            this.datePanel.Location = new System.Drawing.Point(3, 4);
            this.datePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(793, 37);
            this.datePanel.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(6, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(45, 19);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.appointmentDatePicker.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDatePicker.Location = new System.Drawing.Point(57, 4);
            this.appointmentDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(349, 29);
            this.appointmentDatePicker.TabIndex = 0;
            this.appointmentDatePicker.ValueChanged += new System.EventHandler(this.appointmentDatePicker_ValueChanged);
            // 
            // listComboBox
            // 
            this.listComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listComboBox.FormattingEnabled = true;
            this.listComboBox.Items.AddRange(new object[] {
            "Overdue / Late",
            "Finished today",
            "All clients"});
            this.listComboBox.Location = new System.Drawing.Point(802, 12);
            this.listComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listComboBox.Name = "listComboBox";
            this.listComboBox.Size = new System.Drawing.Size(320, 27);
            this.listComboBox.TabIndex = 4;
            this.listComboBox.SelectedIndexChanged += new System.EventHandler(this.listComboBox_SelectedIndexChanged);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.Thistle;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Image = global::AppUI.Properties.Resources.Reports;
            this.reportButton.Location = new System.Drawing.Point(531, 31);
            this.reportButton.Margin = new System.Windows.Forms.Padding(4);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(121, 120);
            this.reportButton.TabIndex = 8;
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // billsButton
            // 
            this.billsButton.BackColor = System.Drawing.Color.BurlyWood;
            this.billsButton.FlatAppearance.BorderSize = 0;
            this.billsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billsButton.Image = global::AppUI.Properties.Resources.Bills;
            this.billsButton.Location = new System.Drawing.Point(402, 31);
            this.billsButton.Margin = new System.Windows.Forms.Padding(4);
            this.billsButton.Name = "billsButton";
            this.billsButton.Size = new System.Drawing.Size(121, 120);
            this.billsButton.TabIndex = 9;
            this.billsButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = global::AppUI.Properties.Resources.Search;
            this.searchButton.Location = new System.Drawing.Point(273, 31);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 120);
            this.searchButton.TabIndex = 10;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // addVisitButton
            // 
            this.addVisitButton.BackColor = System.Drawing.Color.Turquoise;
            this.addVisitButton.FlatAppearance.BorderSize = 0;
            this.addVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVisitButton.Image = global::AppUI.Properties.Resources.AddVisit;
            this.addVisitButton.Location = new System.Drawing.Point(144, 31);
            this.addVisitButton.Margin = new System.Windows.Forms.Padding(4);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(121, 120);
            this.addVisitButton.TabIndex = 11;
            this.addVisitButton.UseVisualStyleBackColor = false;
            this.addVisitButton.Click += new System.EventHandler(this.addVisitButton_Click);
            // 
            // newVisitorButton
            // 
            this.newVisitorButton.BackColor = System.Drawing.Color.RosyBrown;
            this.newVisitorButton.FlatAppearance.BorderSize = 0;
            this.newVisitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newVisitorButton.Image = global::AppUI.Properties.Resources.NewVisitor;
            this.newVisitorButton.Location = new System.Drawing.Point(15, 31);
            this.newVisitorButton.Margin = new System.Windows.Forms.Padding(4);
            this.newVisitorButton.Name = "newVisitorButton";
            this.newVisitorButton.Size = new System.Drawing.Size(121, 120);
            this.newVisitorButton.TabIndex = 12;
            this.newVisitorButton.UseVisualStyleBackColor = false;
            this.newVisitorButton.Click += new System.EventHandler(this.newVisitorButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.developerStatus,
            this.timeStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 754);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1609, 24);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel1.Text = "Status: Administrator";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(59, 19);
            this.toolStripStatusLabel2.Text = "Clients: 4";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(99, 19);
            this.toolStripStatusLabel3.Text = "Appointments: 3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(1175, 19);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = "Contact us:";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // developerStatus
            // 
            this.developerStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.developerStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.developerStatus.IsLink = true;
            this.developerStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.developerStatus.LinkColor = System.Drawing.Color.Green;
            this.developerStatus.Name = "developerStatus";
            this.developerStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.developerStatus.Size = new System.Drawing.Size(68, 19);
            this.developerStatus.Text = "nonats.org";
            this.developerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.developerStatus.Click += new System.EventHandler(this.developerStatus_Click);
            // 
            // timeStatus
            // 
            this.timeStatus.Name = "timeStatus";
            this.timeStatus.Size = new System.Drawing.Size(63, 19);
            this.timeStatus.Text = "timeStatus";
            // 
            // timToday
            // 
            this.timToday.Enabled = true;
            this.timToday.Interval = 1000;
            this.timToday.Tick += new System.EventHandler(this.timToday_Tick);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1609, 778);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.billsButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addVisitButton);
            this.Controls.Add(this.newVisitorButton);
            this.Controls.Add(this.landingTabs);
            this.Controls.Add(this.searchGroup);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LandingForm";
            this.Text = "Veterinary Clinic Management System (Sniffs & Licks)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandingForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.landingTabs.ResumeLayout(false);
            this.appointmentsTab.ResumeLayout(false);
            this.aptLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appGridView)).EndInit();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.TabControl landingTabs;
        private System.Windows.Forms.TabPage appointmentsTab;
        private System.Windows.Forms.TableLayoutPanel aptLayoutPanel;
        private System.Windows.Forms.ComboBox listComboBox;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button billsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addVisitButton;
        private System.Windows.Forms.Button newVisitorButton;
        private System.Windows.Forms.DataGridView appGridView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel developerStatus;
        private System.Windows.Forms.ToolStripStatusLabel timeStatus;
        private System.Windows.Forms.Timer timToday;
    }
}

