using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public interface IOperations
    {
        void addCard();
        void deleteCard();
        void moveCard();
        void boardList();
    }
}
