namespace AppUI
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petList = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.petLabel = new System.Windows.Forms.Label();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.petContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientUpload = new System.Windows.Forms.PictureBox();
            this.clientPicture = new System.Windows.Forms.PictureBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.cellphone = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clientTitle = new System.Windows.Forms.Label();
            this.clientLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.petContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicture)).BeginInit();
            this.clientLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addPetToolStripMenuItem
            // 
            this.addPetToolStripMenuItem.Name = "addPetToolStripMenuItem";
            this.addPetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPetToolStripMenuItem.Text = "New";
            this.addPetToolStripMenuItem.Click += new System.EventHandler(this.addPetToolStripMenuItem_Click);
            // 
            // petList
            // 
            this.petList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petList.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petList.IntegralHeight = false;
            this.petList.ItemHeight = 19;
            this.petList.Location = new System.Drawing.Point(103, 165);
            this.petList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.petList.Name = "petList";
            this.petList.Size = new System.Drawing.Size(509, 141);
            this.petList.TabIndex = 5;
            this.petList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.petList_MouseClick);
            this.petList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.petList_MouseDown);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 10);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(85, 19);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(14, 50);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(83, 19);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last name:";
            // 
            // petLabel
            // 
            this.petLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.petLabel.AutoSize = true;
            this.petLabel.Location = new System.Drawing.Point(63, 225);
            this.petLabel.Name = "petLabel";
            this.petLabel.Size = new System.Drawing.Size(34, 19);
            this.petLabel.TabIndex = 4;
            this.petLabel.Text = "Pet:";
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Location = new System.Drawing.Point(53, 130);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(44, 19);
            this.cellphoneLabel.TabIndex = 7;
            this.cellphoneLabel.Text = "CP #:";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(29, 90);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 19);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address:";
            // 
            // firstName
            // 
            this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName.Location = new System.Drawing.Point(103, 5);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(509, 29);
            this.firstName.TabIndex = 8;
            this.firstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // petContextMenu
            // 
            this.petContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPetToolStripMenuItem,
            this.editPetToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.petContextMenu.Name = "petContextMenu";
            this.petContextMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // editPetToolStripMenuItem
            // 
            this.editPetToolStripMenuItem.Enabled = false;
            this.editPetToolStripMenuItem.Name = "editPetToolStripMenuItem";
            this.editPetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editPetToolStripMenuItem.Text = "Edit";
            this.editPetToolStripMenuItem.Click += new System.EventHandler(this.editPetToolStripMenuItem_Click);
            // 
            // clientUpload
            // 
            this.clientUpload.BackColor = System.Drawing.Color.Transparent;
            this.clientUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clientUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientUpload.Image = ((System.Drawing.Image)(resources.GetObject("clientUpload.Image")));
            this.clientUpload.Location = new System.Drawing.Point(113, 183);
            this.clientUpload.Name = "clientUpload";
            this.clientUpload.Size = new System.Drawing.Size(33, 32);
            this.clientUpload.TabIndex = 9;
            this.clientUpload.TabStop = false;
            this.clientUpload.Click += new System.EventHandler(this.clientUpload_Click);
            // 
            // clientPicture
            // 
            this.clientPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientPicture.BackgroundImage")));
            this.clientPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientPicture.ErrorImage = null;
            this.clientPicture.ImageLocation = "";
            this.clientPicture.InitialImage = null;
            this.clientPicture.Location = new System.Drawing.Point(12, 84);
            this.clientPicture.Name = "clientPicture";
            this.clientPicture.Size = new System.Drawing.Size(128, 128);
            this.clientPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clientPicture.TabIndex = 8;
            this.clientPicture.TabStop = false;
            // 
            // lastName
            // 
            this.lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName.Location = new System.Drawing.Point(103, 45);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(509, 29);
            this.lastName.TabIndex = 8;
            this.lastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.address.Location = new System.Drawing.Point(103, 85);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(509, 29);
            this.address.TabIndex = 8;
            this.address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // cellphone
            // 
            this.cellphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cellphone.Location = new System.Drawing.Point(103, 125);
            this.cellphone.Name = "cellphone";
            this.cellphone.Size = new System.Drawing.Size(509, 29);
            this.cellphone.TabIndex = 8;
            this.cellphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(633, 218);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 309);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // clientTitle
            // 
            this.clientTitle.BackColor = System.Drawing.Color.RosyBrown;
            this.clientTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientTitle.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTitle.Location = new System.Drawing.Point(0, 0);
            this.clientTitle.Name = "clientTitle";
            this.clientTitle.Size = new System.Drawing.Size(737, 75);
            this.clientTitle.TabIndex = 6;
            this.clientTitle.Text = "Owner\'s information";
            this.clientTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientLayoutPanel
            // 
            this.clientLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientLayoutPanel.BackColor = System.Drawing.Color.White;
            this.clientLayoutPanel.ColumnCount = 2;
            this.clientLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.clientLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientLayoutPanel.Controls.Add(this.petList, 1, 4);
            this.clientLayoutPanel.Controls.Add(this.firstNameLabel, 0, 0);
            this.clientLayoutPanel.Controls.Add(this.lastNameLabel, 0, 1);
            this.clientLayoutPanel.Controls.Add(this.petLabel, 0, 4);
            this.clientLayoutPanel.Controls.Add(this.cellphoneLabel, 0, 3);
            this.clientLayoutPanel.Controls.Add(this.addressLabel, 0, 2);
            this.clientLayoutPanel.Controls.Add(this.firstName, 1, 0);
            this.clientLayoutPanel.Controls.Add(this.lastName, 1, 1);
            this.clientLayoutPanel.Controls.Add(this.address, 1, 2);
            this.clientLayoutPanel.Controls.Add(this.cellphone, 1, 3);
            this.clientLayoutPanel.Location = new System.Drawing.Point(12, 218);
            this.clientLayoutPanel.Name = "clientLayoutPanel";
            this.clientLayoutPanel.RowCount = 5;
            this.clientLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientLayoutPanel.Size = new System.Drawing.Size(615, 309);
            this.clientLayoutPanel.TabIndex = 5;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 540);
            this.Controls.Add(this.clientUpload);
            this.Controls.Add(this.clientPicture);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clientTitle);
            this.Controls.Add(this.clientLayoutPanel);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(441, 490);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client\'s Information";
            this.petContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicture)).EndInit();
            this.clientLayoutPanel.ResumeLayout(false);
            this.clientLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPetToolStripMenuItem;
        private System.Windows.Forms.ListBox petList;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label petLabel;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.ContextMenuStrip petContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editPetToolStripMenuItem;
        private System.Windows.Forms.PictureBox clientUpload;
        private System.Windows.Forms.PictureBox clientPicture;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox cellphone;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label clientTitle;
        private System.Windows.Forms.TableLayoutPanel clientLayoutPanel;
    }
}