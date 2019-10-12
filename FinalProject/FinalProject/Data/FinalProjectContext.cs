using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject.Models.Book> Book { get; set; }

        public DbSet<FinalProject.Models.Genre> Genre { get; set; }

        public DbSet<FinalProject.Models.User> User { get; set; }

        public DbSet<FinalProject.Models.UserBook> UserBook { get; set; }
    }
}
