using PrøveEksamen.Models;

namespace PrøveEksamen.Data
{

    public class BankKontoInj
    {

        public static List<Bank> Banks = new List<Bank>();

        public BankKontoInj() 
        {
            Bank b1 = new Bank();
            b1.Id = 1;
            b1.Name = "Jyske bank";
            Bank b2 = new Bank();
            b2.Id = 2;
            b2.Name = "Sparbank";
            Bank b3 = new Bank();
            b3.Id = 3;
            b3.Name = "Danske bank";

            Banks.Add(b1);
            Banks.Add(b2);
            Banks.Add(b3);
        }

        public List<Bank> getAllItems()
        {
            return Banks;
        }
        public Bank getItem(int id)
        {
            return null;
        }
        public void addItem(Bank bank)
        {
            Banks.Add(bank);
        }
    }
}
