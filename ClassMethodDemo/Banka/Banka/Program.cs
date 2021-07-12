<<<<<<< HEAD
﻿using System;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANKA UYGULAMASI\n\n");


            Customer customer1 = new Customer();
            customer1.customerID = 1;
            customer1.customerName = "Mehmet";
            customer1.customerSurname = "Kafkas";
            customer1.customerTCNo = "12345678910";
            customer1.customerAge = 41;
            customer1.customerPhoneNumber = "0532 000 00 01";


            Customer customer2 = new Customer();
            customer2.customerID = 2;
            customer2.customerName = "Aslı";
            customer2.customerSurname = "Aslan";
            customer2.customerTCNo = "98765432100";
            customer2.customerAge = 36;
            customer2.customerPhoneNumber = "0532 000 00 02";

            Customer customer3 = new Customer();
            customer3.customerID = 3;
            customer3.customerName = "Şevval";
            customer3.customerSurname = "Öztürk";
            customer3.customerTCNo = "45678912312";
            customer3.customerAge = 19;
            customer3.customerPhoneNumber = "0535 000 00 03";

            Customer customer4 = new Customer();
            customer4.customerID = 4;
            customer4.customerName = "Musab";
            customer4.customerSurname = "Yılmaz";
            customer4.customerTCNo = "785632146932";
            customer4.customerAge = 21;
            customer4.customerPhoneNumber = "0531 000 00 04";

            Customer customer5 = new Customer();
            customer5.customerID = 5;
            customer5.customerName = "Ahmet";
            customer5.customerSurname = "Tekin";
            customer5.customerTCNo = "32569874104";
            customer5.customerAge = 33;
            customer5.customerPhoneNumber = "0543 000 00 05";


            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);
            customerManager.CustomerAdd(customer4);
            customerManager.CustomerAdd(customer5);

            customerManager.CustomerShow(customer1);
            customerManager.CustomerShow(customer2);
            customerManager.CustomerShow(customer3);
            customerManager.CustomerShow(customer4);
            customerManager.CustomerShow(customer5);

            customerManager.CustomerDel(customer1);
            customerManager.CustomerDel(customer2);
            customerManager.CustomerDel(customer3);
            customerManager.CustomerDel(customer4);
            customerManager.CustomerDel(customer5);
        }
    }
}
=======
﻿using System;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANKA UYGULAMASI\n\n");


            Customer customer1 = new Customer();
            customer1.customerID = 1;
            customer1.customerName = "Mehmet";
            customer1.customerSurname = "Kafkas";
            customer1.customerTCNo = "12345678910";
            customer1.customerAge = 41;
            customer1.customerPhoneNumber = "0532 000 00 01";


            Customer customer2 = new Customer();
            customer2.customerID = 2;
            customer2.customerName = "Aslı";
            customer2.customerSurname = "Aslan";
            customer2.customerTCNo = "98765432100";
            customer2.customerAge = 36;
            customer2.customerPhoneNumber = "0532 000 00 02";

            Customer customer3 = new Customer();
            customer3.customerID = 3;
            customer3.customerName = "Şevval";
            customer3.customerSurname = "Öztürk";
            customer3.customerTCNo = "45678912312";
            customer3.customerAge = 19;
            customer3.customerPhoneNumber = "0535 000 00 03";

            Customer customer4 = new Customer();
            customer4.customerID = 4;
            customer4.customerName = "Musab";
            customer4.customerSurname = "Yılmaz";
            customer4.customerTCNo = "785632146932";
            customer4.customerAge = 21;
            customer4.customerPhoneNumber = "0531 000 00 04";

            Customer customer5 = new Customer();
            customer5.customerID = 5;
            customer5.customerName = "Ahmet";
            customer5.customerSurname = "Tekin";
            customer5.customerTCNo = "32569874104";
            customer5.customerAge = 33;
            customer5.customerPhoneNumber = "0543 000 00 05";


            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);
            customerManager.CustomerAdd(customer4);
            customerManager.CustomerAdd(customer5);

            customerManager.CustomerShow(customer1);
            customerManager.CustomerShow(customer2);
            customerManager.CustomerShow(customer3);
            customerManager.CustomerShow(customer4);
            customerManager.CustomerShow(customer5);

            customerManager.CustomerDel(customer1);
            customerManager.CustomerDel(customer2);
            customerManager.CustomerDel(customer3);
            customerManager.CustomerDel(customer4);
            customerManager.CustomerDel(customer5);
        }
    }
}
>>>>>>> 5d07406a97d5525537787655630dbdd687a24c2c
