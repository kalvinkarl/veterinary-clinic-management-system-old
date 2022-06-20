using AppLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.DataAccess
{
    public class SqlConnector:IDataConnection   
    {
        private const string DatabaseName = "VCMSdb";
        public ClientModel CreateClient(ClientModel client)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                DynamicParameters c = new DynamicParameters();
                c.Add("@Image", client.Image);
                c.Add("@FirstName", client.FirstName);
                c.Add("@LastName", client.LastName);
                c.Add("@Address", client.Address);
                c.Add("@Cellphone", client.Cellphone);
                c.Add("@ID",0,dbType: DbType.Int32,direction: ParameterDirection.Output);
                connection.Execute("spClients_Create", c, commandType: CommandType.StoredProcedure);
                client.ID = c.Get<int>("@ID");
                return client;
            }
        }
        public ClientModel UpdateClient(ClientModel client)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                DynamicParameters c = new DynamicParameters();
                client.DateRegistered = DateTime.Now;
                c.Add("@ID",client.ID);
                c.Add("@Image", client.Image);
                c.Add("@FirstName", client.FirstName);
                c.Add("@LastName", client.LastName);
                c.Add("@Address", client.Address);
                c.Add("@Cellphone", client.Cellphone);
                c.Add("@DateRegistered", client.DateRegistered);
                connection.Execute("spClients_Update", c, commandType: CommandType.StoredProcedure);
                return client;
            }
        }
        public PetModel CreatePet(PetModel pet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("OwnerID", pet.Owner.ID);
                p.Add("Name", pet.Name);
                p.Add("Species", pet.Species);
                p.Add("Breed", pet.Breed);
                p.Add("ColorMarking", pet.ColorMarking);
                p.Add("Age", pet.Age);
                p.Add("Sex", pet.Sex);
                p.Add("Notes", pet.Notes);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("spPets_Create", p, commandType: CommandType.StoredProcedure);
                pet.ID = p.Get<int>("@ID");
                return pet;
            }
        }
    }
}
