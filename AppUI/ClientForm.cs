using AppLibrary;
using AppLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class ClientForm : Form
    {
        public List<PetModel> Pets { get; set; } = new List<PetModel>();
        public ClientModel Client { get; set; }
        public ClientForm()
        {
            InitializeComponent();
        }
        private void FillClient()
        {
            MemoryStream stream = new MemoryStream();
            clientPicture.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            Client.Image = stream.ToArray();
            Client.FirstName = firstName.Text;
            Client.LastName = lastName.Text;
            Client.Address = address.Text;
            Client.Cellphone = cellphone.Text;
        }
        private void OpenPetForm()
        {
            PetForm newPetForm = new PetForm();
            if (Client == null)
            {
                newPetForm.ShowDialog(this);
                if (newPetForm.Pet != null)
                {
                    Client = new ClientModel();
                    FillClient();
                    newPetForm.Pet.Owner = GlobalConfig.Connection.CreateClient(Client);
                }
            }
            else
            {
                newPetForm.Pet.Owner = Client;
                newPetForm.ShowDialog(this);
            }
            Reload();
        }
        private void Save()
        {
            if(firstName.Text.Length > 0 && lastName.Text.Length > 0 && address.Text.Length > 0 && cellphone.Text.Length > 0)
            {
                if(petList.Items.Count > 0)
                {
                    foreach (PetModel pet in Pets)
                    {
                        FillClient();
                        GlobalConfig.Connection.UpdateClient(Client);
                        GlobalConfig.Connection.CreatePet(pet);
                    }
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Pet not found. Please enter atleast 1 pet to proceed");
                }
            }
            else
            {
                MessageBox.Show("Cannot proceed with empty field");
            }
        }
        private void Reload()
        {
            petList.DataSource = null;
            petList.DataSource = Pets;
            petList.DisplayMember = "Name";
        }
        private void clientUpload_Click(object sender, EventArgs e)
        {
            Stream mySteam;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if((mySteam = open.OpenFile()) != null)
                    {
                        string FileName = open.FileName;
                        if (mySteam.Length > 1024000)
                        {
                            MessageBox.Show("Filze size limit exceeded");
                        }
                        else
                        {
                            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                            gp.AddEllipse(0, 0, clientPicture.Width - 3, clientPicture.Height - 3);
                            clientPicture.Region = new Region(gp);
                            clientPicture.Load(FileName);
                            clientPicture.BackgroundImage = null;
                            clientPicture.BackColor = Color.DimGray;
                            clientPicture.BorderStyle = BorderStyle.FixedSingle;
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void petList_MouseClick(object sender, MouseEventArgs e)
        {
            if (petList.Items.Count == 0)
            {
                OpenPetForm();
            }
        }

        private void petList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && petList.Items.Count > 0)
            {
                if (petList.SelectedItems.Count > 0)
                {
                    petContextMenu.Items[1].Enabled = true;
                    petContextMenu.Items[2].Enabled = true;
                }
                else
                {
                    petContextMenu.Items[1].Enabled = false;
                    petContextMenu.Items[2].Enabled = false;
                }
                petContextMenu.Show(Cursor.Position);
            }
        }

        private void editPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (petList.SelectedItems.Count > 0 && petList.Items.Count > 0)
            {
                PetForm newPetForm = new PetForm();
                newPetForm.Pet = (PetModel)petList.SelectedItem;
                Pets.Remove((PetModel)petList.SelectedItem);
                newPetForm.ShowDialog(this);
                Reload();
            }
        }

        private void addPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPetForm();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pets.Remove((PetModel)petList.SelectedItem);
            Reload();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Client != null)
            {
                var window = MessageBox.Show("Are you sure to end this session? all existing records will be deleted", "Are you sure?", MessageBoxButtons.YesNo);
                e.Cancel = (window == DialogResult.No);
            }
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (cellphone.Focused)
                {
                    if (petList.Items.Count == 0)
                    {
                        OpenPetForm();
                    }
                    else
                    {
                        Save();
                    }
                }
                e.SuppressKeyPress = SelectNextControl((Control)sender, true, true, true, true); ;
            }
            if (e.KeyCode == Keys.Up)
            {
                SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
