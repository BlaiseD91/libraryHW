using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class LibraryContext:DbContext
    {
        public DbSet<ClassLibrary.Model.Kolcsonzes> Kolcsonzes { get; set; } = default!;

        public DbSet<ClassLibrary.Model.Kolcsonzo>? Kolcsonzo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=(localdb)\\mssqllocaldb;Database=API.Data;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }

        public LibraryContext()
        {
        }
    }
}
