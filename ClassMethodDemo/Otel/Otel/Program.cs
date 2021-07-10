using System;

namespace Otel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OTEL OTOMASYON PROGRAMI");

            Customer c1 = new Customer();
            c1.ID = 1;
            c1.name = "Ahmet";
            c1.surname = "Er";
            c1.roomNo = 195;

            Customer c2 = new Customer();
            c2.ID = 2;
            c2.name = "Aleyna";
            c2.surname = "Tekin";
            c2.roomNo = 12;

            Customer c3 = new Customer();
            c3.ID = 3;
            c3.name = "Erva";
            c3.surname = "Güzel";
            c3.roomNo = 74;


            CustomerManager cM = new CustomerManager();
            Customer[] customers = new Customer[] { c1, c2, c3 };
            cM.Add(c1);
            cM.Update(c1);
            cM.Show(c1);
            cM.Del(c1);

            cM.Add(c2);
            cM.Update(c2);
            cM.Show(c2);
            cM.Del(c2);

            cM.Add(c3);
            cM.Update(c3);
            cM.Show(c3);
            cM.Del(c3);

        }
    }
}
