using PrøveEksamen.Models;

namespace PrøveEksamen.Data
{
    public interface Int
    {
        public Bank GetBank(int id);
        public List<Bank> GetBanks();
        public void AddBank(Bank bank);
    }
}
