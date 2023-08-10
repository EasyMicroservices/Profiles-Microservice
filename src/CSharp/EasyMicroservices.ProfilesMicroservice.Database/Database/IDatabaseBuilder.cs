using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.ProfilesMicroservice.Database
{
    public interface IDatabaseBuilder
    {
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}
