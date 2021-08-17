using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Board : IOperations
    {
        public Line toDo;
        public Line inProgress;
        public Line done;

        public Line ToDo { get => toDo; set => toDo = value; }
        public Line InProgress { get => inProgress; set => inProgress = value; }
        public Line Done { get => done; set => done = value; }


        public void addCard()
        {
            Console.WriteLine("Başlık giriniz: ");
            string title = Console.ReadLine();

            Console.WriteLine("İçerik giriniz: ");
            string content = Console.ReadLine();

            int size;

            while (true)
            {
                Console.WriteLine("\n1) XS\n2) S\n3) M\n4) L\n5) XL\nKart büyüklüğü seçiniz: ");

                if (int.TryParse(Console.ReadLine(), out int sizeChoose))
                {
                    size = sizeChoose;
                    break;
                }
                else
                {
                    Console.WriteLine("Gerçersiz giriş!");
                }
            }

            Console.WriteLine("**********MEVCUT KİŞİLER***********");

            foreach (var member in Team.team)
            {
                Console.WriteLine(member.Key + "." + member.Value);
            }

            int appointedPerson;

            while (true)
            {
                Console.WriteLine("Atanmış kişi seçiniz: ");

                if (int.TryParse(Console.ReadLine(), out int appointedPersonChoose))
                {
                    appointedPerson = appointedPersonChoose;
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş!");
                }
            }

            Card card = new Card();
            card.Title = title;
            card.Content = content;

            switch (size)
            {
                case 1:
                    card.Size = Size.XS.ToString();
                    break;

                case 2:
                    card.Size = Size.S.ToString();
                    break;

                case 3:
                    card.Size = Size.M.ToString();
                    break;

                case 4:
                    card.Size = Size.L.ToString();
                    break;

                case 5:
                    card.Size = Size.XL.ToString();
                    break;
            }

            card.appointedPersonID = appointedPerson;
            card.currentLine = ToDo;

            ToDo.Cards.Add(card);
            Console.WriteLine("\n ["+card.Title+"] adlı kart başlığı başarıyla eklendi.");
        }

        public void boardList()
        {
            Console.WriteLine("**********TO DO\n************");

            foreach (var card in ToDo.Cards)
            {
                Console.WriteLine("Başlık: " + card.Title);
                Console.WriteLine("İçerik: " + card.Content);
                Console.WriteLine("Atanan Kişi: " + Team.team[card.appointedPersonID]);
                Console.WriteLine("Büyüklük: " + card.Size);
            }

            Console.WriteLine("*********IN PROGRESS LINE\n**********");

            foreach (var card in InProgress.Cards)
            {
                Console.WriteLine("Başlık: " + card.Title);
                Console.WriteLine("İçerik: " + card.Content);
                Console.WriteLine("Atanan Kişi: " + Team.team[card.appointedPersonID]);
                Console.WriteLine("Büyüklük: " + card.Size);
            }

            Console.WriteLine("*********DONE LINE\n***********");

            foreach (var card in Done.Cards)
            {
                Console.WriteLine("Başlık: " + card.Title);
                Console.WriteLine("İçerik: " + card.Content);
                Console.WriteLine("Atanan Kişi: " + Team.team[card.appointedPersonID]);
                Console.WriteLine("Büyüklük: " + card.Size);
            }
        }

        public void deleteCard()
        {
            Console.WriteLine("Silmek istediğiniz kart başlığını giriniz: ");
            string titleSearch = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < ToDo.Cards.Count; i++)
            {
                if (ToDo.Cards[i].Title == titleSearch)
                {
                    counter++;
                    ToDo.Cards.Remove(ToDo.Cards[i]);
                }
            }

            for (int i = 0; i < InProgress.Cards.Count; i++)
            {
                if (InProgress.Cards[i].Title == titleSearch)
                {
                    counter++;
                    InProgress.Cards.Remove(InProgress.Cards[i]);
                }
            }

            for (int i = 0; i < Done.Cards.Count; i++)
            {
                if (Done.Cards[i].Title == titleSearch)
                {
                    counter++;
                    Done.Cards.Remove(Done.Cards[i]);
                }
            }

            if (counter == 1)
            {
                Console.WriteLine(counter + "["+titleSearch+"] kart başlığı silindi!");
            }
            else if (counter != 0)
            {
                Console.WriteLine(counter + "[" + titleSearch + "] kart başlıkları silindi!");
            }
            else if (counter == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı!\n");
                Console.WriteLine("1) Silmeyi sonlandırmak için\n2) Yeniden denemek için\nLütfen bir seçim yapınız: ");

                int select;

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int choose))
                    {
                        select = choose;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                    }
                }

                switch (select)
                {
                    case 1:
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                        break;

                    case 2:
                        deleteCard();
                        break;
                }
            }
        }

        public void moveCard()
        {
            Console.WriteLine("Taşımak istediğiniz kartı giriniz: ");
            string title = Console.ReadLine();

            int counter = 0;

            foreach (var currentCard in ToDo.Cards)
            {
                if (currentCard.Title == title)
                {
                    Console.WriteLine("*****Bulunan kart bilgileri: ");
                    Console.WriteLine("Başlık: " + currentCard.Title);
                    Console.WriteLine("İçerik: " + currentCard.Content);
                    Console.WriteLine("Atanan Kişi: " + Team.team[currentCard.appointedPersonID]);
                    Console.WriteLine("Büyüklük: " + currentCard.Size);
                    Console.WriteLine("Line: " + currentCard.CurrentLine.Name);

                    Console.WriteLine("\n(1) TODO\n(2) IN PROGRESS\n(3) DONELütfen taşımak istediğiniz Line'ı seçiniz: ");

                    int newLineSelect;

                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int choose))
                        {
                            newLineSelect = choose;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş!");
                        }
                    }

                    switch (newLineSelect)
                    {
                        case 1:
                            ToDo.Cards.Add(currentCard);
                            currentCard.CurrentLine.Cards.Remove(currentCard);
                            currentCard.CurrentLine = ToDo;
                            break;

                        case 2:
                            InProgress.Cards.Add(currentCard);
                            currentCard.CurrentLine.Cards.Remove(currentCard);
                            currentCard.CurrentLine = InProgress;
                            break;

                        case 3:
                            Done.Cards.Add(currentCard);
                            currentCard.CurrentLine.Cards.Remove(currentCard);
                            currentCard.CurrentLine = Done;
                            break;
                    }

                    Console.WriteLine();
                    this.boardList();

                    break;
                }
            }

            if (counter != 0)
            {
                title = "";
            }

            foreach (var currentCard in Done.Cards)
            {
                if (currentCard.Title == title)
                {
                    counter++;
                    Console.WriteLine("*****Bulunan kart bilgileri: ");
                    Console.WriteLine("Başlık: " + currentCard.Title);
                    Console.WriteLine("İçerik: " + currentCard.Content);
                    Console.WriteLine("Atanan Kişi: " + Team.team[currentCard.appointedPersonID]);
                    Console.WriteLine("Büyüklük: " + currentCard.Size);
                    Console.WriteLine("Line: " + currentCard.CurrentLine.Name);

                    Console.WriteLine("\n(1) TODO\n(2) IN PROGRESS\n(3) DONELütfen taşımak istediğiniz Line'ı seçiniz: ");

                    int newLineSelect;

                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int choose))
                        {
                            newLineSelect = choose;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş!");
                        }
                    }

                    switch (newLineSelect)
                    {
                        case 1:
                            ToDo.Cards.Add(currentCard);
                            currentCard.CurrentLine.Cards.Remove(currentCard);
                            currentCard.CurrentLine = ToDo;
                            break;

                        case 2:
                            InProgress.Cards.Add(currentCard);
                            currentCard.CurrentLine.Cards.Remove(currentCard);
                            currentCard.CurrentLine = InProgress;
                            break;

                        case 3:
                            Done.Cards.Add(currentCard);
                            currentCard.CurrentLine.Cards.Remove(currentCard);
                            currentCard.CurrentLine = Done;
                            break;
                    }

                    Console.WriteLine();
                    this.boardList();

                    break;
                }
            }

            if (counter == 0)
            {

                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı!\n");
                Console.WriteLine("1) Taşımayı sonlandırmak için\n2) Yeniden denemek için\nLütfen bir seçim yapınız: ");

                int select;

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int choose))
                    {
                        select = choose;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gerçersiz giriş!");
                    }
                }

                switch (select)
                {

                    case 1:
                        Console.WriteLine("Taşıma işlemi sonlandırıldı.");
                        break;

                    case 2:
                        moveCard();
                        break;

                }
            }
        }
    }
}
