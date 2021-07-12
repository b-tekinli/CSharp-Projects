using System;

namespace ShapeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ŞEKİL UYGULAMASINA HOŞ GELDİNİZ :)\n");

            while (true)
            {
                Console.WriteLine("1-Dikdörtgen İşlemleri\n2-Üçgen İşlemleri\n3-Kare İşlemleri\nq-Çıkış Yap\nİşlem seçiniz: ");
                string choose = Console.ReadLine();

                if (choose == "q")
                {
                    Console.WriteLine("\nÇıkış yapıldı.");
                    break;
                }
                else if (choose == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("\n1-Dikdörtgen Alan Hesapla\n2-Bilgileri Göster\nq-Çıkış Yap\nİşlem seçiniz:");
                        string recChoose = Console.ReadLine();

                        if (recChoose == "1")
                        {
                            Console.WriteLine("\nKısa kenarı giriniz: ");
                            int shortSide = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nUzun kenarı giriniz: ");
                            int longSide = Convert.ToInt32(Console.ReadLine());


                            Rectangular rec = new Rectangular("Dikdörtgen", shortSide, longSide);
                            rec.shapeCalculate();
                        }
                        else if (recChoose == "2")
                        {
                            Console.WriteLine("\nKısa kenarı giriniz: ");
                            int shortSide = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nUzun kenarı giriniz: ");
                            int longSide = Convert.ToInt32(Console.ReadLine());


                            Rectangular rec = new Rectangular("Dikdörtgen", shortSide, longSide);
                            rec.shapeShowInfo();
                        }
                        else if (recChoose == "q")
                        {
                            Console.WriteLine("\nDikdörtgen işlemlerinden çıkılıyor...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nHatalı giriş yaptınız lütfen tekrar deneyiniz...");
                        }
                    }
                }
                else if(choose == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("\n1-Üçgen Alan Hesapla\n2-Bilgileri Göster\nq-Çıkış Yap\nİşlem seçiniz:");
                        string triChoose = Console.ReadLine();

                        if (triChoose == "1")
                        {
                            Console.WriteLine("\nÜçgenin taban alanını giriniz: ");
                            int floorArea = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nÜçgenin yüksekliğini giriniz: ");
                            int height = Convert.ToInt32(Console.ReadLine());


                            Triangle tri = new Triangle("Üçgen", floorArea, height);
                            tri.shapeCalculate();
                        }
                        else if (triChoose == "2")
                        {
                            Console.WriteLine("\nÜçgenin taban alanını giriniz: ");
                            int floorArea = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nÜçgenin yüksekliğini giriniz: ");
                            int height = Convert.ToInt32(Console.ReadLine());


                            Triangle tri = new Triangle("Üçgen", floorArea, height);
                            tri.shapeShowInfo();
                        }
                        else if (triChoose == "q")
                        {
                            Console.WriteLine("\nÜçgen işlemlerinden çıkılıyor...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nHatalı giriş yaptınız lütfen tekrar deneyiniz...");
                        }
                    }
                }
                else if (choose == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("\n1-Kare Alan Hesapla\n2-Bilgileri Göster\nq-Çıkış Yap\nİşlem seçiniz:");
                        string squChoose = Console.ReadLine();

                        if (squChoose == "1")
                        {
                            Console.WriteLine("\nKarenin kenarını giriniz: ");
                            int side = Convert.ToInt32(Console.ReadLine());


                            Square squ = new Square("Kare", side);
                            squ.shapeCalculate();
                        }
                        else if (squChoose == "2")
                        {
                            Console.WriteLine("\nKarenin kenarını giriniz: ");
                            int side = Convert.ToInt32(Console.ReadLine());


                            Square squ = new Square("Kare", side);
                            squ.shapeShowInfo();
                        }
                        else if (squChoose == "q")
                        {
                            Console.WriteLine("\nKare işlemlerinden çıkılıyor...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nHatalı giriş yaptınız lütfen tekrar deneyiniz...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nHatalı giriş yaptınız lütfen tekrar deneyiniz...");
                }

            }
        }
    }
}
