using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class ClientModel
    {
        /// <summary>
        /// Represents the primary ID of clients
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents the picture of the client
        /// </summary>
        public byte[] Image { get; set; }
        /// <summary>
        /// Represents the first name of the costumer
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of the costumer
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the costumer home address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Represents the cellphone number to contact the costumer
        /// </summary>
        public string Cellphone { get; set; }
        /// <summary>
        /// Represents the date of the registration
        /// </summary>
        public DateTime DateRegistered { get; set; }
        /// <summary>
        /// Defines all pets of the costumer
        /// </summary>
        public List<PetModel> Pets = new List<PetModel>();
        /// <summary>
        /// Returns the full name of client
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public Bitmap ImageBitmap
        {
            get
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = Image;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
        }
    }
}
