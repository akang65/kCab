using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace DataLibrary.DataAccess
{
    public class SqlDataAccess
    {
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringHelper.ConnValue("DefaultConnection")))
            {
                return connection.Query<T>(sql).ToList();   
            }


        }
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionStringHelper.ConnValue("DefaultConnection")))
            {
                return connection.Execute(sql, data);
            }
        }

    }
}
