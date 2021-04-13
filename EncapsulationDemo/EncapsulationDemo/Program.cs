using System;

namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();

            P1.TCNO = "12345678910";

            Console.WriteLine("TC Kimlik Numaranız: " + P1.TCNO);
        }
    }
}
