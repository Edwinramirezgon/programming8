using Microsoft.EntityFrameworkCore;
using Veterinary.Shared.Entities;

namespace Veterinary.Api.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext>options):base(options) {
        
        }  

        public DbSet<Owner>Owners { get; set; }
        public DbSet<PetType> PetTypes { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }    
        
        public DbSet<History> Historys { get; set; }    

        public DbSet<Agend> Agends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
