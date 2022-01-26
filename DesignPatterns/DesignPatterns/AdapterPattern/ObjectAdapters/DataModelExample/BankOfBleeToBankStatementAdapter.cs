using System;
using System.Collections.Generic;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    /// <summary>
    /// There's a crap-ton of converting 
    /// </summary>
    public class BankOfBleeToBankStatementAdapter : BankStatement
    {
        private readonly BankOfBleeStatement _bankOfBleeStatement;

        public BankOfBleeToBankStatementAdapter(BankOfBleeStatement bankOfBleeStatement)
        {
            _bankOfBleeStatement = bankOfBleeStatement;
        }

        public override string Name
        {
            get
            {
                return $"{_bankOfBleeStatement.FirstName} {_bankOfBleeStatement.LastName}";
            }
            
            set
            {
                string fullName = value;
                string[] nameParts = fullName.Split(' ');
                _bankOfBleeStatement.FirstName = nameParts[0];
                _bankOfBleeStatement.LastName = nameParts[1];
            }                      
        }

        public override string AccountType
        {
            get => _bankOfBleeStatement.Type;
            set => _bankOfBleeStatement.Type = value;
        }

        public override DateTime AccountCreatedOn
        { 
            get => _bankOfBleeStatement.AccountBeganOn;
            set => _bankOfBleeStatement.AccountBeganOn = value; 
        }

        public override List<Tran> Transactions
        { 
            get
            {
                base.Transactions = new List<Tran>();

                foreach (BleeTransaction bleeTran in _bankOfBleeStatement.BleeTransactions)
                {
                    Tran tran = new Tran();
                    if(bleeTran.Type == TransactionType.Debit)
                    {
                        tran.Amount = -(bleeTran.Amount); //make negative
                    }
                    else
                    {
                        tran.Amount = bleeTran.Amount;
                    }
                    tran.Date = bleeTran.Date;

                    base.Transactions.Add(tran);
                }
         
                return base.Transactions;

            }
            set
            {
                List<BleeTransaction> bleeTransactions = new List<BleeTransaction>();

                List<Tran> trans = value;

                foreach(Tran tran in trans)
                {
                    var bleeTransaction = new BleeTransaction();

                    bleeTransaction.Date = tran.Date;

                    if(tran.Amount < 0)
                    {
                        bleeTransaction.Type = TransactionType.Debit;
                    }
                    else
                    {
                        bleeTransaction.Type = TransactionType.Credit;
                    }
                    
                    bleeTransaction.Amount = Math.Abs(tran.Amount);

                    bleeTransactions.Add(bleeTransaction);
                }

                _bankOfBleeStatement.BleeTransactions = bleeTransactions;
            }
            
        }
    }
}
