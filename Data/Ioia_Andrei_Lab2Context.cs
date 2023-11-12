using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nume_Pren_Lab2.Models;

namespace Ioia_Andrei_Lab2.Data
{
    public class Ioia_Andrei_Lab2Context : DbContext
    {
        public Ioia_Andrei_Lab2Context (DbContextOptions<Ioia_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nume_Pren_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
