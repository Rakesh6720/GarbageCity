using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarbageCity.Data
{
    public class GarbageCityContextConnection : DbContext

    {
        public GarbageCityContextConnection(DbContextOptions<GarbageCityContextConnection> options)
            : base(options)
        {
        }
    }
}
