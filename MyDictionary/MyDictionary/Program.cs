using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Bilal");
            names.Add("Aleyna");
            names.Add("Yağmur");

            Console.WriteLine("MyDictionary " + names.Count + " elemanlıdır.");
        }
    }
}
