using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public class AccountFromFileSource
    {
        private string _filePath;

        public AccountFromFileSource(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<BankAccount> GetAccountFromFile()
        {
            BankAccount bankAccount = null;
            string rawFile = await File.ReadAllTextAsync(_filePath);
            bankAccount = JsonConvert.DeserializeObject<BankAccount>(rawFile);

            return bankAccount;
        }
    }
}
