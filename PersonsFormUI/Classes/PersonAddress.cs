using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsFormUI
{
    public class PersonAddress
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string FullPersonAddress
        {
            get
            {
                return $"{ Address } { City } { State } { ZipCode }";
            }
        }
    }
}
