namespace API_150122.Models
{
    public class Sale_Entry
    {
        public int id { get; set; }
        public int sale_id { get; set; }
        public int item_id { get; set; }
        public double qty { get; set; }
        public double rate { get; set; }

        public Sale Sale_obj { get; set; }
    }
}
