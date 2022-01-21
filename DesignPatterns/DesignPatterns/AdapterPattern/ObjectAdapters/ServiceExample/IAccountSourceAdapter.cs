using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.ObjectAdapters
{
    public interface IAccountSourceAdapter
    {
        Task<BankAccount> GetAccount();
    }
}
