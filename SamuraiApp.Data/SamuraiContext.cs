using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SamuraiApp.Domain;
using System.Linq;

namespace SamuraiApp.Data
{
    public class SamuraiContext: DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SamuraiAppData2");
        }


    }
}
