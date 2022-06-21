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
        public PetModel CreatePet(PetModel pet)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("OwnerID", pet.OwnerID);
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
        public VisitModel CreateVisit(VisitModel visit)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                DynamicParameters v = new DynamicParameters();
                v.Add("@PetID", visit.PetID);
                v.Add("@Weight", visit.Weight);
                v.Add("@Temperature", visit.Temperature);
                v.Add("@ComplaintDiagnosis", visit.ComplaintDiagnosis);
                v.Add("@Treatment", visit.Treatment);
                v.Add("@Notes", visit.Notes);
                v.Add("@Date", visit.Date);
                v.Add("@NextVisit", visit.NextVisit);
                v.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("spVisits_Create", v, commandType: CommandType.StoredProcedure);
                visit.ID = v.Get<int>("@ID");
                return visit;
            }
        }
        public BillModel CreateBill(BillModel bill)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                DynamicParameters b = new DynamicParameters();
                b.Add("@VisitID", bill.VisitID);
                b.Add("@InvoiceNumber", bill.InvoiceNumber);
                b.Add("@TotalAmount", bill.TotalAmount);
                b.Add("@PaidAmount", bill.PaidAmount);
                b.Add("@Date", bill.Date);
                b.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("spBills_Create", b, commandType: CommandType.StoredProcedure);
                bill.ID = b.Get<int>("@ID");
                return bill;
            }
        }
        public ClientModel UpdateClient(ClientModel client)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                DynamicParameters c = new DynamicParameters();
                client.DateRegistered = DateTime.Now;
                c.Add("@ID", client.ID);
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

        public List<ClientModel> GetAllClients()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                return connection.Query<ClientModel>("spClients_GetAll", null, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<PetModel> GetPetsByOwnerID(int OwnerID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                return connection.Query<PetModel>("spPets_GetByID", new { OwnerID }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<VisitModel> GetVisitsByPetID(int PetID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                return connection.Query<VisitModel>("spVisits_GetByID", new { PetID }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<BillModel> GetBillByVisitID(int VisitID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                return connection.Query<BillModel>("spBills_GetByID", new { VisitID }, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<ClientModel> GetByTodayClients()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString(DatabaseName)))
            {
                return connection.Query<ClientModel>("spClients_GetByToday", null, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
