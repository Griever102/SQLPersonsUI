using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PersonsFormUI
{
    public static class Helper
    {
        public static string CnnVal(string name)
        {
            //Getting the connection string to communicate with SQLExpress
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
