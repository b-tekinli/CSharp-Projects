using System;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** VOTING APP *****");

            int select = 0;

            Console.WriteLine("\nOylamak istediğiniz kategoriyi seçiniz: ");
            var categoryList = CategoryDataSource.CategoryList;

            for (int i = 0; i < categoryList.Count; i++)
            {
                Console.WriteLine("{0} - {1}", (i+1), (categoryList[i].Name));
            }

            do
            {
                Console.WriteLine("\nSeçiminizi giriniz: ");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Vote("Film/Dizi");
                        break;
                    case 2:
                        Vote("Tech Stack");
                        break;
                    case 3:
                        Vote("Spor");
                        break;
                    case 4:
                        Vote("Müzik");
                        break;
                    case 5:
                        Vote("Oyun");
                        break;
                    default:
                        Console.WriteLine("Geçersiz giriş!");
                        break;
                }
            } while (select >= 1 && select < 5);

            CategoryList();
            CalcVote();
        }

        static void Vote(string categoryName)
        {
            var result = CheckUserControl();

            if (result == true)
            {
                var category = CategoryDataSource.CategoryList.Find(x => x.Name == categoryName);
                category.Vote += 1;
                Console.WriteLine("\nOyunuz, {0} adlı kategoriye başarıyla eklenmiştir.", category.Name);
            }
        }

        static bool CheckUserControl()
        {
            Console.Write("\nOy kullanabilmek için kullanıcı adınızı giriniz:");
            string userName = Console.ReadLine();

            var user = UserDataSource.UserList.Find(x => x.UserName == userName);
            if (user == null)
            {
                AddUser();
            }
            return true;
        }

        static void AddUser()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nÜyeliğiniz bulunamadı!\nÜye olmak istiyor musunuz?\n1-Evet\n2-Hayır\nSeçiminizi giriniz: ");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Kullanıcı adınızı giriniz: ");
                        string username = Console.ReadLine();

                        Console.WriteLine("Adınızı ve soyadınızı giriniz: ");
                        string fullname = Console.ReadLine();

                        UserDataSource.UserList.Add(new User(username, fullname));

                        Console.WriteLine("Üyeliğiniz başarılı bir şekilde yapıldı.");

                        flag = false;
                        break;
                    case 2:
                        Console.WriteLine("Çıkış yapıldı.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz giriş!");
                        flag = false;
                        break;
                }
            }
        }

        static void CategoryList()
        {
            foreach (var item in CategoryDataSource.CategoryList)
            {
                Console.WriteLine("{0} kategorisinin oy sayısı: {1}", item.Name, item.Vote);
            }
        }

        static void CalcVote()
        {
            float cv1 = CategoryDataSource.CategoryList.Find(x => x.Name == "Film/Dizi").Vote;
            float cv2 = CategoryDataSource.CategoryList.Find(x => x.Name == "Tech Stack").Vote;
            float cv3 = CategoryDataSource.CategoryList.Find(x => x.Name == "Spor").Vote;
            float cv4 = CategoryDataSource.CategoryList.Find(x => x.Name == "Müzik").Vote;
            float cv5 = CategoryDataSource.CategoryList.Find(x => x.Name == "Oyun").Vote;

            float cSum1 = 0;
            float cSum2 = 0;
            float cSum3 = 0;
            float cSum4 = 0;
            float cSum5 = 0;

            cSum1 = (cv1 / (cv1 + cv2 + cv3 + cv4 + cv5)) * 100;
            cSum2 = (cv2 / (cv1 + cv2 + cv3 + cv4 + cv5)) * 100;
            cSum3 = (cv3 / (cv1 + cv2 + cv3 + cv4 + cv5)) * 100;
            cSum4 = (cv4 / (cv1 + cv2 + cv3 + cv4 + cv5)) * 100;
            cSum5 = (cv5 / (cv1 + cv2 + cv3 + cv4 + cv5)) * 100;

            Console.WriteLine("Film/Dizi kategorisinin oy yüzdesi = {0}", Math.Round(cSum1, 1));
            Console.WriteLine("Tech Stack kategorisinin oy yüzdesi = {0}", Math.Round(cSum2, 2));
            Console.WriteLine("Spor kategorisinin oy yüzdesi = {0}", Math.Round(cSum3, 3));
            Console.WriteLine("Müzik kategorisinin oy yüzdesi = {0}", Math.Round(cSum4, 4));
            Console.WriteLine("Oyun kategorisinin oy yüzdesi = {0}", Math.Round(cSum5, 5));
        }
    }
}
