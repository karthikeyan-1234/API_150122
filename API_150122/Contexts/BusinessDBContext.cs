using API_150122.Models;

using Microsoft.EntityFrameworkCore;

namespace API_150122.Contexts
{
    public class BusinessDBContext : DbContext, IBusinessDBContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Item_Type> Item_Types { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Purchase_Entry> Purchase_Entries { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Sale_Entry> Sale_Entries { get; set; }
        public DbSet<Uom> Uoms { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public BusinessDBContext(DbContextOptions<BusinessDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
