using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Card
    {
        public string title { get; set; }
        public string content { get; set; }
        public int appointedPersonID { get; set; }
        public string size { get; set; }
        public Line currentLine { get; set; }


        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public int AppointedPersonID { get => appointedPersonID; set => appointedPersonID = value; }
        public string Size { get => size; set => size = value; }
        public Line CurrentLine { get => currentLine; set => currentLine = value; }

        public Card()
        {

        }

        public Card(string title, string content, int appointedPersonID, string size, Line currentLine)
        {
            Title = title;
            Content = content;
            AppointedPersonID = appointedPersonID;
            Size = size;
            CurrentLine = currentLine;
        }
    }

    enum Size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
