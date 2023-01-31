namespace API_150122.Models
{
    public class Uom
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Item> Item_objs { get; set; }
    }
}
