using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    interface IPerson
    {
        public void SaveNumber(Person person);
        public void DelNumber(Person person);
        public void UpdateNumber(Person person);
        public void ListDirectory(Person person);
        public void SearchDirectory(Person person);
    }
}
