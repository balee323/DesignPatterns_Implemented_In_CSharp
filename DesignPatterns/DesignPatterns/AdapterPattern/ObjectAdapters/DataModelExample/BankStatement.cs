using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public class BankStatement
    {
        public virtual string Name { get; set;}
        public virtual string AccountType { get; set; }
        public virtual DateTime AccountCreatedOn { get; set; }
        public virtual List<Tran> Transactions { get; set;}
    }

    public class Tran
    {
        public virtual decimal Amount { get; set; }
        public virtual DateTime Date { get; set; }
    }

    public enum TranType
    {
        Debit,
        Credit
    }

}
