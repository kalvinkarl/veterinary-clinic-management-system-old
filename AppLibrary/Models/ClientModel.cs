using System;
using System.Collections.Generic;
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
        /// Defines the pets of the costumer
        /// </summary>
        public List<PetModel> Pets = new List<PetModel>();
        /// <summary>
        /// Returns the full name of client
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        //public ClientModel DisplayClient {
        //    get { return new ClientModel() { FullName = FullName,Address=Address }; }
        //}

    }
}
