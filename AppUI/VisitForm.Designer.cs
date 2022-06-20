namespace AppUI
{
    partial class VisitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            this.tempLabel = new System.Windows.Forms.Label();
            this.appColTimeLabel = new System.Windows.Forms.Label();
            this.appMinute = new System.Windows.Forms.NumericUpDown();
            this.comDiagLabel = new System.Windows.Forms.Label();
            this.appTime = new System.Windows.Forms.Label();
            this.appHour = new System.Windows.Forms.NumericUpDown();
            this.appGroup = new System.Windows.Forms.GroupBox();
            this.ampm = new System.Windows.Forms.Button();
            this.appBack = new System.Windows.Forms.Button();
            this.appDate = new System.Windows.Forms.DateTimePicker();
            this.appDateLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.tempUnit = new System.Windows.Forms.ComboBox();
            this.weightUnit = new System.Windows.Forms.ComboBox();
            this.treatLabel = new System.Windows.Forms.Label();
            this.appOpen = new System.Windows.Forms.Button();
            this.laterButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paymentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.complaintDiagnosis = new System.Windows.Forms.RichTextBox();
            this.treatment = new System.Windows.Forms.RichTextBox();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.weightLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.visitTitle = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.temp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.appMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appHour)).BeginInit();
            this.appGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp)).BeginInit();
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(12, 140);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(101, 19);
            this.tempLabel.TabIndex = 29;
            this.tempLabel.Text = "Temperature:";
            // 
            // appColTimeLabel
            // 
            this.appColTimeLabel.AutoSize = true;
            this.appColTimeLabel.Location = new System.Drawing.Point(104, 76);
            this.appColTimeLabel.Name = "appColTimeLabel";
            this.appColTimeLabel.Size = new System.Drawing.Size(12, 19);
            this.appColTimeLabel.TabIndex = 14;
            this.appColTimeLabel.Text = ":";
            // 
            // appMinute
            // 
            this.appMinute.Location = new System.Drawing.Point(118, 73);
            this.appMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.appMinute.Name = "appMinute";
            this.appMinute.Size = new System.Drawing.Size(43, 29);
            this.appMinute.TabIndex = 13;
            // 
            // comDiagLabel
            // 
            this.comDiagLabel.AutoSize = true;
            this.comDiagLabel.Location = new System.Drawing.Point(3, 0);
            this.comDiagLabel.Name = "comDiagLabel";
            this.comDiagLabel.Size = new System.Drawing.Size(158, 19);
            this.comDiagLabel.TabIndex = 0;
            this.comDiagLabel.Text = "Complaint/Diagnosis:";
            // 
            // appTime
            // 
            this.appTime.AutoSize = true;
            this.appTime.Location = new System.Drawing.Point(5, 75);
            this.appTime.Name = "appTime";
            this.appTime.Size = new System.Drawing.Size(46, 19);
            this.appTime.TabIndex = 15;
            this.appTime.Text = "Time:";
            // 
            // appHour
            // 
            this.appHour.InterceptArrowKeys = false;
            this.appHour.Location = new System.Drawing.Point(57, 73);
            this.appHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.appHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.appHour.Name = "appHour";
            this.appHour.Size = new System.Drawing.Size(45, 29);
            this.appHour.TabIndex = 12;
            this.appHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // appGroup
            // 
            this.appGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appGroup.Controls.Add(this.ampm);
            this.appGroup.Controls.Add(this.appBack);
            this.appGroup.Controls.Add(this.appDate);
            this.appGroup.Controls.Add(this.appTime);
            this.appGroup.Controls.Add(this.appDateLabel);
            this.appGroup.Controls.Add(this.appColTimeLabel);
            this.appGroup.Controls.Add(this.appHour);
            this.appGroup.Controls.Add(this.appMinute);
            this.appGroup.Location = new System.Drawing.Point(369, 64);
            this.appGroup.Name = "appGroup";
            this.appGroup.Size = new System.Drawing.Size(326, 118);
            this.appGroup.TabIndex = 31;
            this.appGroup.TabStop = false;
            this.appGroup.Text = "Appointment:";
            this.appGroup.Visible = false;
            // 
            // ampm
            // 
            this.ampm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.ampm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ampm.Location = new System.Drawing.Point(167, 73);
            this.ampm.Name = "ampm";
            this.ampm.Size = new System.Drawing.Size(66, 29);
            this.ampm.TabIndex = 36;
            this.ampm.Text = "AM";
            this.ampm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ampm.UseVisualStyleBackColor = true;
            this.ampm.Click += new System.EventHandler(this.ampm_Click);
            // 
            // appBack
            // 
            this.appBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.appBack.FlatAppearance.BorderSize = 0;
            this.appBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appBack.Location = new System.Drawing.Point(239, 73);
            this.appBack.Name = "appBack";
            this.appBack.Size = new System.Drawing.Size(68, 29);
            this.appBack.TabIndex = 20;
            this.appBack.Text = "Back";
            this.appBack.UseVisualStyleBackColor = false;
            this.appBack.Click += new System.EventHandler(this.appOpenClose_Click);
            // 
            // appDate
            // 
            this.appDate.Location = new System.Drawing.Point(57, 38);
            this.appDate.Name = "appDate";
            this.appDate.Size = new System.Drawing.Size(250, 29);
            this.appDate.TabIndex = 5;
            this.appDate.Value = new System.DateTime(2022, 3, 23, 0, 0, 0, 0);
            // 
            // appDateLabel
            // 
            this.appDateLabel.AutoSize = true;
            this.appDateLabel.Location = new System.Drawing.Point(7, 45);
            this.appDateLabel.Name = "appDateLabel";
            this.appDateLabel.Size = new System.Drawing.Size(44, 19);
            this.appDateLabel.TabIndex = 0;
            this.appDateLabel.Text = "Date:";
            // 
            // noteLabel
            // 
            this.noteLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(3, 364);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(53, 19);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "Notes:";
            // 
            // tempUnit
            // 
            this.tempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tempUnit.FormattingEnabled = true;
            this.tempUnit.Items.AddRange(new object[] {
            "°C",
            "°F"});
            this.tempUnit.Location = new System.Drawing.Point(187, 137);
            this.tempUnit.Name = "tempUnit";
            this.tempUnit.Size = new System.Drawing.Size(40, 27);
            this.tempUnit.TabIndex = 33;
            // 
            // weightUnit
            // 
            this.weightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightUnit.FormattingEnabled = true;
            this.weightUnit.Items.AddRange(new object[] {
            "kg",
            "hg",
            "dag",
            "g"});
            this.weightUnit.Location = new System.Drawing.Point(187, 104);
            this.weightUnit.Name = "weightUnit";
            this.weightUnit.Size = new System.Drawing.Size(40, 27);
            this.weightUnit.TabIndex = 32;
            // 
            // treatLabel
            // 
            this.treatLabel.AutoSize = true;
            this.treatLabel.Location = new System.Drawing.Point(3, 182);
            this.treatLabel.Name = "treatLabel";
            this.treatLabel.Size = new System.Drawing.Size(83, 19);
            this.treatLabel.TabIndex = 0;
            this.treatLabel.Text = "Treatment:";
            // 
            // appOpen
            // 
            this.appOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.appOpen.FlatAppearance.BorderSize = 0;
            this.appOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appOpen.Location = new System.Drawing.Point(369, 67);
            this.appOpen.Name = "appOpen";
            this.appOpen.Size = new System.Drawing.Size(326, 29);
            this.appOpen.TabIndex = 34;
            this.appOpen.Text = "If next appointment needed";
            this.appOpen.UseVisualStyleBackColor = false;
            this.appOpen.Click += new System.EventHandler(this.appOpenClose_Click);
            // 
            // laterButton
            // 
            this.laterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.laterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laterButton.FlatAppearance.BorderSize = 0;
            this.laterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laterButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laterButton.Image = ((System.Drawing.Image)(resources.GetObject("laterButton.Image")));
            this.laterButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.laterButton.Location = new System.Drawing.Point(3, 338);
            this.laterButton.Name = "laterButton";
            this.laterButton.Size = new System.Drawing.Size(101, 329);
            this.laterButton.TabIndex = 21;
            this.laterButton.Text = "Pay Later";
            this.laterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.laterButton.UseVisualStyleBackColor = false;
            this.laterButton.Click += new System.EventHandler(this.laterButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(163)))));
            this.paymentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentButton.FlatAppearance.BorderSize = 0;
            this.paymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentButton.Image")));
            this.paymentButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.paymentButton.Location = new System.Drawing.Point(3, 3);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(101, 329);
            this.paymentButton.TabIndex = 8;
            this.paymentButton.Text = "Payment";
            this.paymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.paymentButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.laterButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(698, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(107, 670);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.Controls.Add(this.label1, 1, 0);
            this.tablePanel.Controls.Add(this.comDiagLabel, 0, 0);
            this.tablePanel.Controls.Add(this.noteLabel, 0, 4);
            this.tablePanel.Controls.Add(this.treatLabel, 0, 2);
            this.tablePanel.Controls.Add(this.complaintDiagnosis, 0, 1);
            this.tablePanel.Controls.Add(this.treatment, 0, 3);
            this.tablePanel.Controls.Add(this.notes, 0, 5);
            this.tablePanel.Controls.Add(this.label2, 1, 2);
            this.tablePanel.Controls.Add(this.label3, 1, 4);
            this.tablePanel.Location = new System.Drawing.Point(12, 188);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 6;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanel.Size = new System.Drawing.Size(683, 546);
            this.tablePanel.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "<🧷Add attachment>";
            // 
            // complaintDiagnosis
            // 
            this.tablePanel.SetColumnSpan(this.complaintDiagnosis, 2);
            this.complaintDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaintDiagnosis.Location = new System.Drawing.Point(3, 23);
            this.complaintDiagnosis.Name = "complaintDiagnosis";
            this.complaintDiagnosis.Size = new System.Drawing.Size(677, 156);
            this.complaintDiagnosis.TabIndex = 24;
            this.complaintDiagnosis.Text = "";
            // 
            // treatment
            // 
            this.tablePanel.SetColumnSpan(this.treatment, 2);
            this.treatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatment.Location = new System.Drawing.Point(3, 205);
            this.treatment.Name = "treatment";
            this.treatment.Size = new System.Drawing.Size(677, 156);
            this.treatment.TabIndex = 25;
            this.treatment.Text = "";
            // 
            // notes
            // 
            this.tablePanel.SetColumnSpan(this.notes, 2);
            this.notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notes.Location = new System.Drawing.Point(3, 387);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(677, 156);
            this.notes.TabIndex = 26;
            this.notes.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "<🧷Add attachment>";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "<🧷Add attachment>";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(113, 67);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(250, 29);
            this.date.TabIndex = 27;
            this.date.Value = new System.DateTime(2022, 3, 20, 16, 35, 12, 0);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(53, 105);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(62, 19);
            this.weightLabel.TabIndex = 23;
            this.weightLabel.Text = "Weight:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(71, 70);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 19);
            this.dateLabel.TabIndex = 24;
            this.dateLabel.Text = "Date:";
            // 
            // visitTitle
            // 
            this.visitTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.visitTitle.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitTitle.Location = new System.Drawing.Point(0, 0);
            this.visitTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visitTitle.Name = "visitTitle";
            this.visitTitle.Size = new System.Drawing.Size(813, 55);
            this.visitTitle.TabIndex = 25;
            this.visitTitle.Text = "VISIT";
            this.visitTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weight
            // 
            this.weight.DecimalPlaces = 2;
            this.weight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.weight.Location = new System.Drawing.Point(113, 103);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(71, 29);
            this.weight.TabIndex = 36;
            // 
            // temp
            // 
            this.temp.DecimalPlaces = 2;
            this.temp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.temp.Location = new System.Drawing.Point(113, 136);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(71, 29);
            this.temp.TabIndex = 36;
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 747);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.appGroup);
            this.Controls.Add(this.tempUnit);
            this.Controls.Add(this.weightUnit);
            this.Controls.Add(this.appOpen);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.date);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.visitTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(825, 370);
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VisitForm";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appHour)).EndInit();
            this.appGroup.ResumeLayout(false);
            this.appGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label appColTimeLabel;
        private System.Windows.Forms.NumericUpDown appMinute;
        private System.Windows.Forms.Label comDiagLabel;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label treatLabel;
        private System.Windows.Forms.Label appTime;
        private System.Windows.Forms.NumericUpDown appHour;
        private System.Windows.Forms.GroupBox appGroup;
        private System.Windows.Forms.Button appBack;
        private System.Windows.Forms.DateTimePicker appDate;
        private System.Windows.Forms.Label appDateLabel;
        private System.Windows.Forms.ComboBox tempUnit;
        private System.Windows.Forms.ComboBox weightUnit;
        private System.Windows.Forms.Button appOpen;
        private System.Windows.Forms.Button laterButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label visitTitle;
        private System.Windows.Forms.RichTextBox complaintDiagnosis;
        private System.Windows.Forms.RichTextBox treatment;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ampm;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.NumericUpDown temp;
    }
}