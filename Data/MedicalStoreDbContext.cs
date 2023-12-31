using MedicalStore.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalStore.Data
{
    public class MedicalStoreDbContext :  DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public MedicalStoreDbContext(DbContextOptions<MedicalStoreDbContext> options) : base(options)
        {
        }

    }
}
