using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPattern.ObjectAdapters.DataModelExample
{
    public class DataModelAdapter_InAction
    {

        public BankStatement GetBankStatement()
        {

            BankOfBleeStatement bankOfBlee = GetBankOfBleeStatement();

            BankStatement bankStatement = new BankOfBleeToBankStatementAdapter(bankOfBlee);

            return bankStatement;

        }


        private BankOfBleeStatement GetBankOfBleeStatement()
        {
            BankOfBleeStatement bankOfBleeStatement = new BankOfBleeStatement
            {
                AccountBeganOn = DateTime.Parse("2018-03-07"),
                FirstName = "Brian",
                LastName = "Lee",
                BleeTransactions = new List<BleeTransaction>
                {
                    new BleeTransaction
                    {
                        Amount = 75.68m,
                        Date = DateTime.Parse("2021-12-15"),
                        Type = TranType.Debit

                    },
                    new BleeTransaction
                    {
                        Amount = 1850.00m,
                        Date = DateTime.Parse("2021-12-30"),
                        Type = TranType.Credit

                    },

                }
            };

            return bankOfBleeStatement;
        }
    } 
} 
 