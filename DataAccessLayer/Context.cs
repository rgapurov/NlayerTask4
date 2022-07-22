using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L799HNF\SQLEXPRESS; Database=bodev; Trusted_Connection=true");

        }
        public DbSet<book> books { get; set; }
        public DbSet<publisher> publishers { get; set; }
    }
}
