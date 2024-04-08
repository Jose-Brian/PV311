using PV31.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV31
{
    public class DataContext:DbContext

    {
        public DbSet<Seller> Sellers { get; set; } 
        public DataContext():base("namecon") { }
    }
}
