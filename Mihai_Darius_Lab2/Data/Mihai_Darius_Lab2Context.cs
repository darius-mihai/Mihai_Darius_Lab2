using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mihai_Darius_Lab2.Models;

namespace Mihai_Darius_Lab2.Data
{
    public class Mihai_Darius_Lab2Context : DbContext
    {
        public Mihai_Darius_Lab2Context (DbContextOptions<Mihai_Darius_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mihai_Darius_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Mihai_Darius_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Mihai_Darius_Lab2.Models.Author> Author { get; set; }
    }
}
