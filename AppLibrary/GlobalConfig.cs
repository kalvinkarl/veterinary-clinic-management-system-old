using AppLibrary.DataAccess;
using AppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public enum DatabaseType { Sql}

    public class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnection(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
        }
        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static List<ClientModel> InitializeClientRecords()
        {
            List<ClientModel> Clients = Connection.GetAllClients();
            foreach (ClientModel client in Clients)
            {
                client.Pets = Connection.GetPetsByOwnerID(client.ID);
                foreach (PetModel pet in client.Pets)
                {
                    pet.Visits = Connection.GetVisitsByPetID(pet.ID);
                    foreach (VisitModel visit in pet.Visits)
                    {
                        visit.Bill = Connection.GetBillByVisitID(visit.ID).First();
                    }
                }
            }
            return Clients;
        }

    }
}
