using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AtmApp.Enums;

namespace AtmApp
{
    public static class Logger
    {
        public static void CreateFile(LogTypes type, Person person, Person toTransaction, string operation)
        {
            string fileName = $"Logs/{type}_{DateTime.Now.ToShortDateString().Replace(".", "")}.txt";

            string logString = "";

            if (type == LogTypes.Fraud)
            {
                logString = $"[{type}] [{DateTime.Now.ToShortDateString()} - {DateTime.Now.ToShortTimeString()}] {person.fullname}  {operation}";

            }
            if (type == LogTypes.Transaction)
            {
                logString = $"[{type}] [{DateTime.Now.ToShortDateString()} - {DateTime.Now.ToShortTimeString()}]  {person.fullname} to {toTransaction.fullname}  - {operation}";
            }
            if (logString == "")
            {
                logString = $"Loglama hatası {DateTime.Now} tarihinde meydana geldi.";
            }

            if (!File.Exists(fileName))
            {
                using (StreamWriter streamwriter = File.CreateText(fileName))
                {
                    streamwriter.WriteLine(logString);
                }
            }

            using (StreamWriter streamWriter = File.AppendText(fileName))
            {
                streamWriter.WriteLine(logString);
            }
        }
    }
}
