using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Uppgift6Avancerat.Models;

namespace Uppgift6Avancerat.Context
{
    public class KundContext : DbContext
    {
        public DbSet<Kunder> Kund { get; set; }
    }
}