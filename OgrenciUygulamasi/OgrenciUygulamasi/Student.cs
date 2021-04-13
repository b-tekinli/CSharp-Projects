using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciUygulamasi
{
    public class Student
    {
        private string name;
        private string surname;
        private int no;
        private int age;
        private double midtermExam;
        private double finalExam;
        private string schoolName;

        public Student(string _name, string _surname, int _no, int _age, double _midtermExam, double _finalExam, string _schoolName)
        {
            name = _name;
            surname = _surname;
            no = _no;
            age = _age;
            midtermExam = _midtermExam;
            finalExam = _finalExam;
            schoolName = _schoolName;
        }


        public void showStudentInformation()
        {
            Console.WriteLine("Öğrenci Adı: " + name);
            Console.WriteLine("Öğrenci Soyadı: " + surname);
            Console.WriteLine("Öğrenci Numarası: " + no);
            Console.WriteLine("Öğrenci Yaşı: " + age);
            Console.WriteLine("Öğrenci Vize Notu: " + midtermExam);
            Console.WriteLine("Öğrenci Final Notu: " + finalExam);
            Console.WriteLine("Öğrenci Okul Adı: " + schoolName);
        }

        public double findStudentAverage()
        {
            double average = (midtermExam * 0.4) + (finalExam * 0.6);
            return average;
        }

        public void showSchool()
        {
            Console.WriteLine("Öğrencinin Okul Adı: " + schoolName);
        }

    }
}
