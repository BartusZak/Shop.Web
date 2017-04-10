using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop.Web.Models
{
    public class WszystkieDBtxt : DbContext
    {
        public DbSet<Wszystkie> Ksiazki { get; set; }
    }
}