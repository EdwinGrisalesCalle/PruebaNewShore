using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaIngresoNewShore.Models
{
    public class ClassContext: DbContext
    {   
        public ClassContext()
            : base("PruebaNewshoreContext")
        {
        }
        public DbSet<Flights> Fligths { get; set; }

    }
}