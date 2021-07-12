using System;
using System.Collections.Generic;
using System.Text;

namespace Banka
{
    class CustomerManager
    {
        public void CustomerAdd(Customer tempCustomer)
        {
            Console.WriteLine("*****\n");
            Console.WriteLine("{0} {1} adlı müşteriniz sisteme eklendi.", tempCustomer.customerName, tempCustomer.customerSurname);
            Console.WriteLine("*************************************************\n\n");
        }


        public void CustomerShow(Customer tempCustomer)
        {
            Console.WriteLine("************Müşteri Listeleme************\n");
            Console.WriteLine("ID: {0}", tempCustomer.customerID);
            Console.WriteLine("Adı: {0}", tempCustomer.customerName);
            Console.WriteLine("Soyadı: {0}", tempCustomer.customerSurname);
            Console.WriteLine("TC No: {0}", tempCustomer.customerTCNo);
            Console.WriteLine("Yaşı: {0}", tempCustomer.customerAge);
            Console.WriteLine("Telefon Numarası: {0}", tempCustomer.customerPhoneNumber);
        }


        public void CustomerShow(Customer[] tempCustomerArray)                          // Overloading
        {
            Console.WriteLine("************Müşteri Listeleme************\n");
            foreach (var customer in tempCustomerArray)
            {
                Console.WriteLine("ID: {0}", customer.customerID);
                Console.WriteLine("Adı: {0}", customer.customerName);
                Console.WriteLine("Soyadı: {0}", customer.customerSurname);
                Console.WriteLine("TC No: {0}", customer.customerTCNo);
                Console.WriteLine("Yaşı: {0}", customer.customerAge);
                Console.WriteLine("Telefon Numarası: {0}", customer.customerPhoneNumber);
                Console.WriteLine("*************************************************\n\n");
            }
        }


        public void CustomerDel(Customer tempCustomer)
        {
            Console.WriteLine("******\n");
            Console.WriteLine("{0} {1} adlı müşteriniz sistemden silindi.", tempCustomer.customerName, tempCustomer.customerSurname);
            Console.WriteLine("*************************************************\n\n");
        }
    }
}
