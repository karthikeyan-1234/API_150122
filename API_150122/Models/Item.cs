namespace API_150122.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int uom_id { get; set; }
        public int item_type_id { get; set; }

        public Item_Type Item_Type_obj { get; set; }
        public Uom Uom_obj { get; set; }

    }
}
