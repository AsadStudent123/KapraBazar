using KapraBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapraBazar.Database
{
    public class KapraBazarContext : DbContext
    {
        public KapraBazarContext() :base("KapraBazarConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
