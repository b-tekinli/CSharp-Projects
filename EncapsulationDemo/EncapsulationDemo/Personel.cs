using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationDemo
{
    public class Personel
    {
        private string TcNo;
        public string TCNO
        {
            get
            {
                return TcNo.Substring(0, 5) + "******";
            }

            set
            {
                bool control = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]); //123456789

                        if (sayiMi)
                        {
                            // yapmam gereken bir şey yok
                        }
                        else
                        {
                            control = true;
                            break;
                        }
                    }

                    if (control)
                    {
                        Console.WriteLine("TC kimlik numaranızda geçersiz karakter bulundu.");
                    }
                    else
                    {
                        TcNo = value;
                    }
                }

                else
                {
                    Console.WriteLine("Girdiğiniz TC kimlik numarası 11 karakterli değildir.");
                }
            }

        }
    }
}
