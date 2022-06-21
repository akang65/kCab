 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataLibrary.DataAccess
{
    internal class ConnectionStringHelper
    {
        public static string ConnValue(string name)
        {
            //connection string connector
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
