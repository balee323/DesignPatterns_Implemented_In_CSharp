using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    /// <summary>
    /// So we have a problem with incompatible interfaces between a client and the provider.
    /// Let's say we have a program that fetches data from a file and an API
    /// </summary>
    public class TheProblem_AdapterPattern
    {
        public async Task<BankAccount> FetchData(Source source)
        {

            //The problem is this is not sustainable code.
            //Breaks SOLID principles:
            //Violates the Single Responsibility Principle
            //Violates the Open/Closed Principle - "more than 1 reason to change" and allows for modification

            BankAccount bankAccount = null;
        
            if (source == Source.FromFile)
            {
                string rawFile = await System.IO.File.ReadAllTextAsync(@"C:\temp\somefile.txt");
                bankAccount = JsonConvert.DeserializeObject<BankAccount>(rawFile);
            }
            else if(source == Source.FromAPI)
            {
                using var client = new HttpClient();
                string rawData = await client.GetStringAsync("someUrl");
                bankAccount = JsonConvert.DeserializeObject<BankAccount>(rawData);
            }

            return bankAccount;
        }

    }
}
