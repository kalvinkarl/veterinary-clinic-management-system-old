using AppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// Make new client record and save it to database
        /// </summary>
        /// <param name="client">Client information</param>
        /// <returns>Client model</returns>
        ClientModel CreateClient(ClientModel client);
        /// <summary>
        /// Make new pet record and save it to database
        /// </summary>
        /// <param name="pet">Pet information</param>
        /// <returns>Pet model</returns>
        PetModel CreatePet(PetModel pet);
    }
}
