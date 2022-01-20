using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PersonsFormUI.Classes
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PersonInfo")))
            {
                return connection.Query<Person>("dbo.spPeople_GetInfo @LastName", new { LastName = lastName }).ToList();
            }
        }
    }
}
