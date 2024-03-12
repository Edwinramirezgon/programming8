using Microsoft.EntityFrameworkCore;
using Veterinary.Shared.Entities;

namespace Veterinary.Api.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext>options):base(options) {
        
        }  

        public DbSet<Owner>Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
