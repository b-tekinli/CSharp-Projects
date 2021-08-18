using System;

namespace AreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** ALAN HESAPLAMA *****\n");

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\n1-Daire\n2-Üçgen\n3-Kare\n4-Dikdörtgen\nq-Çıkış\nLütfen seçim yapınız: ");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Circle circle = new();

                        Console.WriteLine("\n1-Alan\n2-Çevre\n3-Hacim\nq-Menü\nLütfen seçim yapınız: ");
                        string selectCircle = Console.ReadLine();

                        if (selectCircle == "1")
                        {
                            circle.Area();
                        }
                        else if (selectCircle == "2")
                        {
                            circle.Circumference();
                        }
                        else if (selectCircle == "3")
                        {
                            circle.Volume();
                        }
                        else if (selectCircle == "q")
                        {
                            Console.WriteLine("Çıkış yapıldı.");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş!");
                        }
                        break;
                    case "2":
                        Triangle triangle = new();

                        Console.WriteLine("\n1-Alan\n2-Çevre\n3-Hacim\nq-Menü\nLütfen seçim yapınız: ");
                        string selectTriangle = Console.ReadLine();

                        if (selectTriangle == "1")
                        {
                            triangle.Area();
                        }
                        else if (selectTriangle == "2")
                        {
                            triangle.Circumference();
                        }
                        else if (selectTriangle == "3")
                        {
                            triangle.Volume();
                        }
                        else if (selectTriangle == "q")
                        {
                            Console.WriteLine("Çıkış yapıldı.");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş!");
                        }
                        break;
                    case "3":
                        Square square = new();

                        Console.WriteLine("\n1-Alan\n2-Çevre\n3-Hacim\nq-Menü\nLütfen seçim yapınız: ");
                        string selectSquare = Console.ReadLine();

                        if (selectSquare == "1")
                        {
                            square.Area();
                        }
                        else if (selectSquare == "2")
                        {
                            square.Circumference();
                        }
                        else if (selectSquare == "3")
                        {
                            square.Volume();
                        }
                        else if (selectSquare == "q")
                        {
                            Console.WriteLine("Çıkış yapıldı.");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş!");
                        }
                        break;
                    case "4":
                        Rectangle rectangle = new();

                        Console.WriteLine("\n1-Alan\n2-Çevre\n3-Hacim\nq-Menü\nLütfen seçim yapınız: ");
                        string selectRectangle = Console.ReadLine();

                        if (selectRectangle == "1")
                        {
                            rectangle.Area();
                        }
                        else if (selectRectangle == "2")
                        {
                            rectangle.Circumference();
                        }
                        else if (selectRectangle == "3")
                        {
                            rectangle.Volume();
                        }
                        else if (selectRectangle == "q")
                        {
                            Console.WriteLine("Çıkış yapıldı.");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş!");
                        }
                        break;
                    case "q":
                        Console.WriteLine("Çıkış yapıldı.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz giriş!");
                        break;
                }
            }
        }
    }
}
