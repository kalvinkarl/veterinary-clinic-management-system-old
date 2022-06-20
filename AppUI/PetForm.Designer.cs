namespace AppUI
{
    partial class PetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetForm));
            this.petLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.consultButton = new System.Windows.Forms.Button();
            this.templatesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notes = new System.Windows.Forms.RichTextBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.sexLabel = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.colorMarkingLabel = new System.Windows.Forms.Label();
            this.breedLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.species = new System.Windows.Forms.TextBox();
            this.breed = new System.Windows.Forms.TextBox();
            this.colorMarking = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.petTitle = new System.Windows.Forms.Label();
            this.petLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.petLayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.petLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // petLayoutButtons
            // 
            this.petLayoutButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petLayoutButtons.ColumnCount = 1;
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.petLayoutButtons.Controls.Add(this.saveButton, 0, 0);
            this.petLayoutButtons.Controls.Add(this.consultButton, 0, 1);
            this.petLayoutButtons.Location = new System.Drawing.Point(500, 84);
            this.petLayoutButtons.Name = "petLayoutButtons";
            this.petLayoutButtons.RowCount = 2;
            this.petLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.petLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.petLayoutButtons.Size = new System.Drawing.Size(98, 353);
            this.petLayoutButtons.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 170);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // consultButton
            // 
            this.consultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.consultButton.FlatAppearance.BorderSize = 0;
            this.consultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultButton.Image = ((System.Drawing.Image)(resources.GetObject("consultButton.Image")));
            this.consultButton.Location = new System.Drawing.Point(3, 179);
            this.consultButton.Name = "consultButton";
            this.consultButton.Size = new System.Drawing.Size(92, 171);
            this.consultButton.TabIndex = 10;
            this.consultButton.Text = "Consult";
            this.consultButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.consultButton.UseVisualStyleBackColor = false;
            this.consultButton.Click += new System.EventHandler(this.consultButton_Click);
            // 
            // templatesContextMenu
            // 
            this.templatesContextMenu.Name = "notesContextMenu";
            this.templatesContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // notes
            // 
            this.petLayoutPanel.SetColumnSpan(this.notes, 5);
            this.notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notes.Location = new System.Drawing.Point(123, 203);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(357, 147);
            this.notes.TabIndex = 1;
            this.notes.Text = "";
            // 
            // female
            // 
            this.female.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(403, 168);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(77, 23);
            this.female.TabIndex = 7;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            this.age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.age.InterceptArrowKeys = false;
            this.age.Location = new System.Drawing.Point(123, 165);
            this.age.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(73, 29);
            this.age.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(63, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // male
            // 
            this.male.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(336, 168);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(61, 23);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            this.sexLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(202, 170);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(62, 19);
            this.sexLabel.TabIndex = 0;
            this.sexLabel.Text = "Months";
            // 
            // speciesLabel
            // 
            this.speciesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(53, 50);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(64, 19);
            this.speciesLabel.TabIndex = 0;
            this.speciesLabel.Text = "Species:";
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(78, 170);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(39, 19);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "Age:";
            // 
            // colorMarkingLabel
            // 
            this.colorMarkingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorMarkingLabel.AutoSize = true;
            this.colorMarkingLabel.Location = new System.Drawing.Point(5, 130);
            this.colorMarkingLabel.Name = "colorMarkingLabel";
            this.colorMarkingLabel.Size = new System.Drawing.Size(112, 19);
            this.colorMarkingLabel.TabIndex = 0;
            this.colorMarkingLabel.Text = "Color Marking:";
            // 
            // breedLabel
            // 
            this.breedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.breedLabel.AutoSize = true;
            this.breedLabel.Location = new System.Drawing.Point(65, 90);
            this.breedLabel.Name = "breedLabel";
            this.breedLabel.Size = new System.Drawing.Size(52, 19);
            this.breedLabel.TabIndex = 0;
            this.breedLabel.Text = "Breed:";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petLayoutPanel.SetColumnSpan(this.name, 5);
            this.name.Location = new System.Drawing.Point(123, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(357, 29);
            this.name.TabIndex = 1;
            // 
            // species
            // 
            this.species.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petLayoutPanel.SetColumnSpan(this.species, 5);
            this.species.Location = new System.Drawing.Point(123, 45);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(357, 29);
            this.species.TabIndex = 2;
            // 
            // breed
            // 
            this.breed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petLayoutPanel.SetColumnSpan(this.breed, 5);
            this.breed.Location = new System.Drawing.Point(123, 85);
            this.breed.Name = "breed";
            this.breed.Size = new System.Drawing.Size(357, 29);
            this.breed.TabIndex = 3;
            // 
            // colorMarking
            // 
            this.colorMarking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petLayoutPanel.SetColumnSpan(this.colorMarking, 5);
            this.colorMarking.Location = new System.Drawing.Point(123, 125);
            this.colorMarking.Name = "colorMarking";
            this.colorMarking.Size = new System.Drawing.Size(357, 29);
            this.colorMarking.TabIndex = 4;
            // 
            // notesLabel
            // 
            this.notesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(64, 267);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(53, 19);
            this.notesLabel.TabIndex = 0;
            this.notesLabel.Text = "Notes:";
            // 
            // petTitle
            // 
            this.petTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.petTitle.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle.Location = new System.Drawing.Point(-1, 0);
            this.petTitle.Name = "petTitle";
            this.petTitle.Size = new System.Drawing.Size(612, 70);
            this.petTitle.TabIndex = 2;
            this.petTitle.Text = "Patient\'s information";
            this.petTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petLayoutPanel
            // 
            this.petLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petLayoutPanel.ColumnCount = 6;
            this.petLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.petLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.petLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.petLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.petLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.petLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.petLayoutPanel.Controls.Add(this.notes, 1, 5);
            this.petLayoutPanel.Controls.Add(this.age, 1, 4);
            this.petLayoutPanel.Controls.Add(this.nameLabel, 0, 0);
            this.petLayoutPanel.Controls.Add(this.sexLabel, 2, 4);
            this.petLayoutPanel.Controls.Add(this.speciesLabel, 0, 1);
            this.petLayoutPanel.Controls.Add(this.ageLabel, 0, 4);
            this.petLayoutPanel.Controls.Add(this.colorMarkingLabel, 0, 3);
            this.petLayoutPanel.Controls.Add(this.breedLabel, 0, 2);
            this.petLayoutPanel.Controls.Add(this.name, 1, 0);
            this.petLayoutPanel.Controls.Add(this.species, 1, 1);
            this.petLayoutPanel.Controls.Add(this.breed, 1, 2);
            this.petLayoutPanel.Controls.Add(this.colorMarking, 1, 3);
            this.petLayoutPanel.Controls.Add(this.notesLabel, 0, 5);
            this.petLayoutPanel.Controls.Add(this.female, 5, 4);
            this.petLayoutPanel.Controls.Add(this.male, 4, 4);
            this.petLayoutPanel.Controls.Add(this.label1, 3, 4);
            this.petLayoutPanel.Location = new System.Drawing.Point(11, 84);
            this.petLayoutPanel.Name = "petLayoutPanel";
            this.petLayoutPanel.RowCount = 6;
            this.petLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.petLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.petLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.petLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.petLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.petLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.petLayoutPanel.Size = new System.Drawing.Size(483, 353);
            this.petLayoutPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sex:";
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.petLayoutButtons);
            this.Controls.Add(this.petTitle);
            this.Controls.Add(this.petLayoutPanel);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(603, 371);
            this.Name = "PetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PetForm";
            this.Load += new System.EventHandler(this.PetForm_Load);
            this.petLayoutButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.petLayoutPanel.ResumeLayout(false);
            this.petLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel petLayoutButtons;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button consultButton;
        private System.Windows.Forms.ContextMenuStrip templatesContextMenu;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.TableLayoutPanel petLayoutPanel;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label colorMarkingLabel;
        private System.Windows.Forms.Label breedLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox species;
        private System.Windows.Forms.TextBox breed;
        private System.Windows.Forms.TextBox colorMarking;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label petTitle;
        private System.Windows.Forms.Label label1;
    }
}