namespace API_150122.Models
{
    public class Purchase
    {
        public int id { get; set; }
        public DateTime date_of_purchase { get; set; }
        public int vendor_id { get; set; }
        public string bill_no { get; set; }

        public Vendor Vendor_obj { get; set; }
        public ICollection<Purchase_Entry> Purchase_Entries { get; set; }
    }
}
