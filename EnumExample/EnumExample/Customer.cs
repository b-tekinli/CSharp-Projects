using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string email { get; set; }


        public Customer(int id, string name, string surname, string gender, string email)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.email = email;
        }


        public static ArrayList customers = new ArrayList();


        public CustomerStatus customerAdd(Customer c1)
        {
            customers.Add(c1);          // musteri koleksiyona eklendi.


            // return 414141;          // değerin eklendiği anlamına gelsin.

            return CustomerStatus.RegistrationSuccessful;
        }
    }
}
