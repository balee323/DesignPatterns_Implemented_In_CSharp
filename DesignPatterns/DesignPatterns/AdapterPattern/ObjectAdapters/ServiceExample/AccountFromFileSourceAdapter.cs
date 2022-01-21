using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public class AccountFromFileSourceAdapter : IAccountSourceAdapter
    {
        private AccountFromFileSource _accountFromFileSource;

        public AccountFromFileSourceAdapter(string filePath)
        {
            _accountFromFileSource = new AccountFromFileSource(filePath);         
        }

        public async Task<BankAccount> GetAccount()
        {
            BankAccount bankAccount = null;
            bankAccount = await _accountFromFileSource.GetAccountFromFile();

            return bankAccount;
        }
    }
}
