using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataLibrary.DataAccess;

namespace DataLibrary.Logic
{
    public static class AdminProcessor
    {
        public static int CreateAdmin(int adminId, string name,
            string lastname,string phoneNumber,
            string email)
        {
            AgentAdminModels data = new AgentAdminModels
            {
                AdminId = adminId,
                Name = name,
                LastName = lastname,
                PhoneNumber=phoneNumber,    
                EmailAddress = email
            };
            string sql = @"Insert into dbo.Agent(AdminId,Name,LastName,PhoneNumber,EmailAddress)
                            values(@AdminId,@Name,@LastName,@EmailAddress)";
            return SqlDataAccess.SaveData(sql, data);
        }

        //load data  will use stored procedure later
        public static List<AgentAdminModels> LoadAdmin()
        {
            string sql = @"select AdminId,AdminId,Name,LastName,EmailAddress from
                            dbo.Agent;";
            return SqlDataAccess.LoadData<AgentAdminModels>(sql);
        }
    }
}
