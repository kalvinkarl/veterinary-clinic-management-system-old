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
    public partial class ClientForm : Form
    {
        public ClientModel Client { get; set; } = new ClientModel();
        public List<PetModel> Pets { get; set; } = new List<PetModel>();
        public ClientForm()
        {
            InitializeComponent();
        }
        private void OpenPetForm()
        {
            Client.FirstName = firstName.Text;
            Client.LastName = lastName.Text;
            Client.Address = address.Text;
            Client.Cellphone = cellphone.Text;

            PetForm newPetForm = new PetForm();
            newPetForm.ShowDialog(this);
            petList.DataSource = null;
            petList.DataSource = Pets;
            petList.DisplayMember = "Name";
        }


        private void clientUpload_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                clientPicture.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
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
                        //Saving();
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

        private void petList_MouseClick(object sender, MouseEventArgs e)
        {
            if (petList.Items.Count == 0)
            {
                OpenPetForm();
            }
        }

        private void petList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
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
            if(petList.SelectedItems.Count > 0)
            {
                PetForm newPetForm = new PetForm();
                newPetForm.Pet = (PetModel)petList.SelectedItem;
                Pets.Remove((PetModel)petList.SelectedItem);
                newPetForm.ShowDialog(this);
                petList.DataSource = null;
                petList.DataSource = Pets;
                petList.DisplayMember = "Name";
            }
        }

        private void addPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPetForm();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pets.Remove((PetModel)petList.SelectedItem);
            petList.DataSource = null;
            petList.DataSource = Pets;
            petList.DisplayMember = "Name";
        }
    }
}
