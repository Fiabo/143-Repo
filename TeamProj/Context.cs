using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TeamProj
{
    class Context : DbContext
    {
        public DbSet<Salesman> Salesmen { get; set; }
        public DbSet<Goods> Good { get; set; }

        public Context():
            base("TeamBDOnline")
        {
                    
        }
    }
}
