using System;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Berat", "Yılmaz", "Erkek", "beratyilmaz@gmail.com");

            /*
            customer.id = 1;
            customer.name = "Berat";
            customer.surname = "Yılmaz";
            customer.gender = "Erkek";
            customer.email = "beratyilmaz@gmail.com";
            */


            // int code = customer.customerAdd(customer);

            /*
            if (code == 414141)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");
            }
            */

            CustomerStatus returnStatus = customer.customerAdd(customer);

            if (returnStatus == CustomerStatus.RegistrationSuccessful)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");
            }
        }
    }
}
