using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public class AccountFromAPISourceAdapter : IAccountSourceAdapter
    {
        private AccountFromAPISource _accountFromAPISource = new AccountFromAPISource();

        public async Task<BankAccount> GetAccount()
        {
            BankAccount bankAccount = null;

            bankAccount = await _accountFromAPISource.GetAccountFromAPI();

            return bankAccount;
        }
    }
}
