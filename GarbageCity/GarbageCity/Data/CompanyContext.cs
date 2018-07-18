using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GarbageCity.Models;

namespace GarbageCity.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext (DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<GarbageCity.Models.Customer> Customer { get; set; }

        public DbSet<GarbageCity.Models.Employee> Employee { get; set; }
    }


}
