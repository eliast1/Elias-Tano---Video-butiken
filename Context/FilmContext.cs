using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Uppgift6Avancerat.Models;

namespace Uppgift6Avancerat.Context
{
    public class FilmContext : DbContext
    {
        public DbSet<Filmer> Filmer { get; set; }
    }
}