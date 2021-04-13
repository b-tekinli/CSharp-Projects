using System;

namespace dizilerle_not_kaydetme_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 5 adaet sınav notu giriniz: ");
            int[] exams = new int[5];
            for (int i = 0; i < 5; i++)
            {
                exams[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Değiştirmek istediğiniz sınav notu için 1' basınız.\nSilmek istediğiniz sınav varsa 2'ye basınız." +
                "\nSınavlarınızı yüksekten düşüğe doğru sıralamak için 3'e basınız.");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("Hangi notu değiştirmek istiyorsunuz?: ");
                    int note = int.Parse(Console.ReadLine());
                    int noteIndex = Array.IndexOf(exams, note);
                    if (noteIndex != 1)
                    {
                        Console.WriteLine("Güncel notunuzu yazınız: ");
                        int newNote = int.Parse(Console.ReadLine());
                        exams[note] = newNote;
                        Console.WriteLine("Notunuz güncellendi.");
                        foreach (var item in exams)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir not girilmedi.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Hangi notu silmek istiyorsunuz?: ");
                    note = int.Parse(Console.ReadLine());
                    noteIndex = Array.IndexOf(exams, note);
                    if (noteIndex != 1)
                    {
                        // kullanıcının yazdığı notun bulunması durumu
                        Array.Clear(exams, noteIndex, 1);
                        Console.WriteLine("Notunuz silindi.");
                        foreach (var item in exams)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir not girilmedi.");
                    }
                    break;

                case 3:
                    Array.Sort(exams);
                    Array.Reverse(exams);
                    foreach (var item in exams)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                default:
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen tekrar deneyiniz...");
                    break;
            }

            Console.ReadKey();

        }
    }
}
