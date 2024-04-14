using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Model;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Model.Kolcsonzes> Kolcsonzes { get; set; } = default!;

        public DbSet<ClassLibrary.Model.Kolcsonzo>? Kolcsonzo { get; set; }
    }
}
