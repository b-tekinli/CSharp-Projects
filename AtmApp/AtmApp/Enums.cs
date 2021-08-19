using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp
{
    public class Enums
    {
        public enum Operations
        {
            successfull = 100,
            insufficientBalance
        }


        public enum LogTypes
        {
            Transaction = 1,
            Fraud,
            Deposit
        }
    }
}
