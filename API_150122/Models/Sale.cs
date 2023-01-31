namespace API_150122.Models
{
    public class Sale
    {
        public int id { get; set; }
        public DateTime date_of_sale { get; set; }
        public int customer_id { get; set; }
        public string sale_no { get; set; }

        public ICollection<Sale_Entry> Sale_Entries { get; set; }
        public Customer Customer_obj { get; set; }
    }
}
