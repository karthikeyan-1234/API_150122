namespace API_150122.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string mobile_no { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
