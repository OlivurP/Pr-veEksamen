namespace PrøveEksamen.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Konto>? KontoList { get; set; }
    }

}
