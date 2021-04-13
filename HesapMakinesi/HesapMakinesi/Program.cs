using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesine Hoşgeldiniz :)");

            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(2, 12);
            dortIslem.Cikar(4, 3);
            dortIslem.Carp(6, 5);
            dortIslem.Bol(81, 9);
        }
    }
}
