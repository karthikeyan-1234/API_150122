namespace API_150122.Models
{
    public class Vendor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
    }
}
