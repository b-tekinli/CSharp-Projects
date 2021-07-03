using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ÖĞRENCİ BİLGİLERİ SİSTEMİNE HOŞGELDİNİZ :)");

            Student student = new Student(200119037, "Beyza", "Tekinli", 93.4, 92.6, "Anadolu Üniversitesi");


            Console.Write("1- Öğrenci Bilgilerini Göster\n2- Öğrenci Ortalamasını Göster\n3- Öğrencinin OKulunu Öğren\n4- Çıkış Yap\nSeçim yapınız: ");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    student.showStdInfo();
                    break;
                case 2:
                    Console.WriteLine("Öğrencinin Ortalaması: " + student.findStdAverage());
                    break;
                case 3:
                    student.showSchoolName();
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapıldı.");
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız lütfen tekrar deneyiniz...");
                    break;
            }
        }
    }
}
