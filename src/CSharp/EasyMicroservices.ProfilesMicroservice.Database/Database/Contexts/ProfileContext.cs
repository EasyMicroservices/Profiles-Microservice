using EasyMicroservices.ProfilesMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.ProfilesMicroservice.Database.Contexts
{
    public class ProfileContext : DbContext
    {
        IDatabaseBuilder _builder;
        public ProfileContext(IDatabaseBuilder builder)
        {
            _builder = builder;
        }

        public DbSet<ProfileEntity> Profiles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_builder != null)
                _builder.OnConfiguring(optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProfileEntity>(model =>
            {
                model.HasKey(x => x.Id);
            });

        }
    }
}