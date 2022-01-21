using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public class AccountFromAPISource
    {
        public async Task<BankAccount> GetAccountFromAPI()
        {
            BankAccount bankAccount = null;

            using var client = new HttpClient();
            string rawData = await client.GetStringAsync("someUrl");
            bankAccount = JsonConvert.DeserializeObject<BankAccount>(rawData);

            return bankAccount;
        }
    }
}
