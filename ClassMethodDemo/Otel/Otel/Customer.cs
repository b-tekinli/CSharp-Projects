using System;
using System.Collections.Generic;
using System.Text;

namespace Otel
{
    class Customer
    {
        public int ID { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public int identityNumber { get; set; }    // private olarak tutulursa daha güvenli olur.
        /* {
            get
            {
                return identityNumber;
            }

            set
            {
                if (value.ToString().Length == 11)
                {
                    identityNumber = value;
                }
                else
                {
                    Console.WriteLine("TC Kimlik numaranızın 11 haneli olduğundan emin olarak tekrar deneyiniz...");
                }
            }
        } */

        public int roomNo { get; set; }
        /* {
            get
            {
                return roomNo;
            }

            set
            {
                if (value <= 200 && value > 0)
                {
                    roomNo = value;
                }
                else
                {
                    Console.WriteLine("Oda numaranız 1 - 200 arasında olmalıdır. Lütfen tekrar deneyiniz...");
                }
            }
        } */

    }
}
