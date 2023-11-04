using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.ProfilesMicroservice.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ProfilesMicroservice
{
    public class DatabaseBuilder : IEntityFrameworkCoreDatabaseBuilder
    {
        IConfiguration _configuration;
        public DatabaseBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ProfileDatabase");
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("local"));
        }
    }
}
