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
        /// <param name="client">Client informations</param>
        /// <returns>Client model</returns>
        ClientModel CreateClient(ClientModel client);

        /// <summary>
        /// Make new pet record and save it to database
        /// </summary>
        /// <param name="pet">Pet informations</param>
        /// <returns>Pet model</returns>
        PetModel CreatePet(PetModel pet);

        /// <summary>
        /// Make new visit record and save it to database
        /// </summary>
        /// <param name="bill">Visit informations</param>
        /// <returns>Visit model</returns>
        VisitModel CreateVisit(VisitModel visit);

        /// <summary>
        /// Make new payment bill and save it to database
        /// </summary>
        /// <param name="bill">Bill informations</param>
        /// <returns>Bill model</returns>
        BillModel CreateBill(BillModel bill);

        /// <summary>
        /// Edit existing client record and save it to database
        /// </summary>
        /// <param name="client">Client informations</param>
        /// <returns>Client model</returns>
        ClientModel UpdateClient(ClientModel client);

        //List<ClientModel> GetAllClients();
        List<PetModel> GetPetsByOwnerID(int OwnerID);
        List<VisitModel> GetVisitsByPetID(int PetID);
        List<BillModel> GetBillByVisitID(int VisitID);
        List<ClientModel> GetAllWithPetVisitsOfClients();
        List<ClientModel> GetTodayVisitsOfClients(); 
        List<ClientModel> GetVisitsOfClients();

        //Templates
        TemplateModel CreateTemplate(TemplateModel template);
        TemplateModel UpdateTemplate(TemplateModel template);
        void DeleteTemplate(TemplateModel template);
        List<TemplateModel> GetTemplatesByCategory(string category);

    }
}
