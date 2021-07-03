using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Student
    {

        // Variables
        private int stdNo;
        private string stdName;
        private string stdSurname;
        private double stdMidtermExam;
        private double stdFinalExam;
        private string stdSchoolName;


        // Ctor
        public Student(int _stdNo, string _stdName, string _stdSurname, double _stdMidtermExam, double _stdFinalExam, string _stdSchoolName)
        {
            stdNo = _stdNo;
            stdName = _stdName;
            stdSurname = _stdSurname;
            stdMidtermExam = _stdMidtermExam;
            stdFinalExam = _stdFinalExam;
            stdSchoolName = _stdSchoolName;
        }


        // Methods
        public void showStdInfo()
        {
            Console.WriteLine("Numarası: " + stdNo);
            Console.WriteLine("Adı: " + stdName);
            Console.WriteLine("Soyadı: " + stdSurname);
            Console.WriteLine("Vize: " + stdMidtermExam);
            Console.WriteLine("Final: " + stdFinalExam);
        }


        public double findStdAverage()
        {
            double result = (stdMidtermExam * 0.4) + (stdFinalExam * 0.6);

            return result;
        }


        public void showSchoolName()
        {
            Console.WriteLine("Okul Adı: " + stdSchoolName);
        }
    }
}
