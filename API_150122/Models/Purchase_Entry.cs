namespace API_150122.Models
{
    public class Purchase_Entry
    {
        public int id { get; set; }
        public int purchase_id { get; set; }
        public int item_id { get; set; }
        public double rate { get; set; }
        public double qty { get; set; }

        public Purchase Purchase_obj { get; set; }
    }
}
