using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    public class Category
    {
        private string name;
        private float vote;

        public Category(string name, float vote)
        {
            this.Name = name;
            this.Vote = vote;
        }

        public string Name { get => name; set => name = value; }
        public float Vote { get => vote; set => vote = value; }
    }

    public static class CategoryDataSource
    {
        public static List<Category> CategoryList;

        static CategoryDataSource()
        {
            CategoryList = AddCategories();
        }

        private static List<Category> AddCategories()
        {
            return new List<Category>()
            {
                new Category("Film/Dizi", 10),
                new Category("Tech Stack", 2),
                new Category("Spor", 9),
                new Category("Müzik", 6),
                new Category("Oyun", 8)
            };
        }
    }
}
