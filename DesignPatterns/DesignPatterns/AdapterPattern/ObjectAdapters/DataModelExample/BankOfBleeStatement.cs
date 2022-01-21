using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public class BankOfBleeStatement
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public DateTime AccountBeganOn { get; set; }
        public List<BleeTransaction> BleeTransactions { get; set; }
    }

    public class BleeTransaction
    {
        public decimal Amount { get; set;}
        public TranType Type { get; set;}
        public DateTime Date { get; set;}
    }
}
