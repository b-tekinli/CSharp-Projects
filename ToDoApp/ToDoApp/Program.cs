using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** TO DO APP **********");

            Board board = new Board();

            board.ToDo = new Line();
            board.ToDo.Cards = new List<Card>();
            board.ToDo.Name = "To Do";

            board.InProgress = new Line();
            board.InProgress.Cards = new List<Card>();
            board.InProgress.Name = "In Progress";

            board.Done = new Line();
            board.Done.Cards = new List<Card>();
            board.Done.Name = "Done";


            Card card1 = new Card("Matematik Çalışmak", "Konu tekrarı yap.", 1, Size.L.ToString(), board.ToDo);
            Card card2 = new Card("İspanyolca Çalışmak", "Kelime ezberi yap.", 2, Size.XS.ToString(), board.InProgress);
            Card card3 = new Card("OOP Çalışmak", "C# ile çalış.", 3, Size.M.ToString(), board.Done);

            board.ToDo.Cards.Add(card1);
            board.InProgress.Cards.Add(card2);
            board.Done.Cards.Add(card3);

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\n1) Board Listelemek\n2) Board'a Kart Eklemek\n3) Board'dan Kart Silmek\n4) Kart Taşımak\nq) Çıkış için\nLütfen yapmak istediğiniz işlemi seçiniz: ");
                string select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                        board.boardList();
                        break;
                    case "2":
                        board.addCard();
                        break;
                    case "3":
                        board.deleteCard();
                        break;
                    case "4":
                        board.moveCard();
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
