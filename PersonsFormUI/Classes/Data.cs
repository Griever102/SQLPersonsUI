using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsFormUI
{
    public class Data
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullData
        {
            get
            {
                return $"{ EmailAddress } { PhoneNumber }";
            }
        }
    }
}
