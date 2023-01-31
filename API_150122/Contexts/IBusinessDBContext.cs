using API_150122.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API_150122.Contexts
{
    public interface IBusinessDBContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Item_Type> Item_Types { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<Purchase_Entry> Purchase_Entries { get; set; }
        DbSet<Purchase> Purchases { get; set; }
        DbSet<Sale_Entry> Sale_Entries { get; set; }
        DbSet<Sale> Sales { get; set; }
        DbSet<Uom> Uoms { get; set; }
        DbSet<Vendor> Vendors { get; set; }

        DbSet<T> Set<T>() where T : class;
        EntityEntry Entry(object obj);
        Task<int> SaveChangesAsync(CancellationToken token = default);
    }
}