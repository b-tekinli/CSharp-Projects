using System;

namespace OgrenciUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            Student student = new Student("Aslı", "Aslan", 500, 17, 91.4, 100, "İstanbul Üniversitesi");

            Console.WriteLine("ÖĞRENCİ UYGULAMASI\n");

            choices();
            Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            int choose = int.Parse(Console.ReadLine());

            while (control)
            {
                switch (choose)
                {
                    case 1:

                        student.showStudentInformation();
                        break;

                    case 2:

                        double stdAverage = student.findStudentAverage();
                        Console.WriteLine("Öğrencinin ortalaması: " + stdAverage);
                        break;

                    case 3:

                        student.showSchool();
                        break;

                    case 4:

                        control = false;
                        break;

                    default:
                        break;
                }
                break;
            }

        }

        static void choices()
        {
            Console.WriteLine("1) Öğrenci Bilgilerini Göster\n2) Öğrencinin Ortalamasını Göster\n3) Okulun İsmini Göster\n4) Çıkış Yap");
        }
    }
}
