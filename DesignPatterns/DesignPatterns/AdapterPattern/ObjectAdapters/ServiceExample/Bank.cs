using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public class Bank
    {
        public async Task<BankAccount> FetchData(Source source)
        {
            BankAccount bankAccount = null;
            IAccountSourceAdapter accountSourceAdapter = null;;

            //we can further decouple this by using a Factory pattern
            if (source == Source.FromFile)
            {
                var filePath = @"C:/temp/bleeAccount.txt";
                accountSourceAdapter = new AccountFromFileSourceAdapter(filePath);
            }
            else if (source == Source.FromAPI)
            {
                accountSourceAdapter = new AccountFromAPISourceAdapter();
            }

            bankAccount = await accountSourceAdapter?.GetAccount();
            return bankAccount;
        }
    }
}
