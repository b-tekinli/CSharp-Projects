using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    public static class DataGenerator
    {
        public static List<Person> Persons = new List<Person>()
        {
            new Person{fullname = "Burcu Ak", balance = 7854.41f, iban = "45679812301", pass = "0123", identityNo = "12345678910"},
            new Person{fullname = "Ahmet Turan", balance = 1248.16f, iban = "74589812301", pass = "1234", identityNo = "14567238910"},
            new Person{fullname = "Bilal Tok", balance = 123.71f, iban = "54121812301", pass = "2345", identityNo = "12789134560"},
            new Person{fullname = "Doruk Polat", balance = 74.61f, iban = "79819812301", pass = "3456", identityNo = "56789101234"},
            new Person{fullname = "Aleyna Saygı", balance = 45.23f, iban = "45623798101", pass = "7896", identityNo = "12349105678"}
        };
    }
}
