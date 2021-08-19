using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    public class User
    {
        private string userName;
        private string fullName;

        public User(string userName, string fullName)
        {
            this.UserName = userName;
            this.FullName = fullName;
        }

        public string UserName { get => userName; set => userName = value; }
        public string FullName { get => fullName; set => fullName = value; }
    }

    public static class UserDataSource
    {
        public static List<User> UserList;

        static UserDataSource()
        {
            UserList = AddUsers();
        }

        public static List<User> AddUsers() 
        {
            return new List<User>()
            {
                new User("aleynaturk", "Aleyna Türk"),
                new User("emretekin", "Emre Tekin"),
                new User("yagmurkaya", "Yağmur Kaya"),
                new User("ahmetyilmaz", "Ahmet Yılmaz"),
                new User("handebal", "Hande Bal")
            };
        }
    }
}
