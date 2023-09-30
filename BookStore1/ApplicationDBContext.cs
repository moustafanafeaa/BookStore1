using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BookStore1
{
    internal class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source = DESKTOP-41U9JGO\\SQLEXPRESS; Initial Catalog = bookstore;Integrated Security = True;TrustServerCertificate=True");
               
        }
        public DbSet<book> books { get; set; }
    }
}
