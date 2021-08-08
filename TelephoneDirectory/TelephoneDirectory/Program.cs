using System;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REHBER\n\n");

            Person person1 = new Person() { name = "Emir", surname = "Yılmaz", number = "0500 000 00 00" };
            Person person2 = new Person() { name = "Berat", surname = "Öz", number = "0500 000 00 01" };
            Person person3 = new Person() { name = "Yaren", surname = "Ak", number = "0500 000 00 02" };
            Person person4 = new Person() { name = "Selin", surname = "Türk", number = "0500 000 00 03" };
            Person person5 = new Person() { name = "Şevval", surname = "Demir", number = "0500 000 00 04" };
        }
    }
}
