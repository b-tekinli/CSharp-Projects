using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Line
    {
        public string name;
        public List<Card> cards;

        public List<Card> Cards { get => cards; set => cards = value; }
        public string Name { get => name; set => name = value; }
    }
}
