using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    interface IPerson
    {
        void SaveNumber(Person person);
        void DelNumber(Person person);
        void UpdateNumber(Person person);
        void ListDirectory(Person person);
        void SearchDirectory(Person person);
    }
}
