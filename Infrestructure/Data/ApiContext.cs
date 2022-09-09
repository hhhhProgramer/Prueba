using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrestructure.Data
{
    public partial class ApiContext : DbContext
    {
          public ApiContext()
        {
        }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> contact { get; set; }
        public virtual DbSet<AddressLines> addressLines { get; set; }
      

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.ApplyConfiguration<Animal>(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());*/
        }
    }
}