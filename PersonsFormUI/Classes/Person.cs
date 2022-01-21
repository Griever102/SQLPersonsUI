using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsFormUI
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int PersonID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        //public int PersonID { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullData
        {
            get
            {
                return $"{ EmailAddress } { PhoneNumber }";
            }
        }

        public string FullPersonAddress
        {
            get
            {
                return $"{ Address } { City } { State } { ZipCode }";
            }
        }

        public string FullPerson
        {
            get 
            {
                    // FirstName LastName
                return $"{ FirstName } { LastName } { PhoneNumber } { EmailAddress }";
            }
        }

    }
}
