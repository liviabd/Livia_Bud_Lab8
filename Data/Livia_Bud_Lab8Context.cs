using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Livia_Bud_Lab8.Models;

namespace Livia_Bud_Lab8.Data
{
    public class Livia_Bud_Lab8Context : DbContext
    {
        public Livia_Bud_Lab8Context (DbContextOptions<Livia_Bud_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

        public DbSet<Livia_Bud_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Livia_Bud_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
