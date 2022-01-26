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

            //All the conversion occurs in the getters/setters (properties)
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
                Type = "Checking Account",
                BleeTransactions = new List<BleeTransaction>
                {
                    new BleeTransaction
                    {
                        Amount = 75.68m,
                        Date = DateTime.Parse("2021-12-15"),
                        Type = TransactionType.Debit

                    },
                    new BleeTransaction
                    {
                        Amount = 1850.00m,
                        Date = DateTime.Parse("2021-12-30"),
                        Type = TransactionType.Credit

                    },

                }
            };

            return bankOfBleeStatement;
        }

    } 
} 
 