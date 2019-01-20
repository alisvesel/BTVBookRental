using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTVBookRental.Models;

namespace BTVBookRental.Models
{
    public class BTVBookRentalContext : DbContext
    {
        public BTVBookRentalContext (DbContextOptions<BTVBookRentalContext> options)
            : base(options)
        {
        }

        public DbSet<BTVBookRental.Models.Book> Book { get; set; }

        public DbSet<BTVBookRental.Models.Student> Student { get; set; }

        public DbSet<UserAccount> UserAccount { get; set; }
    }
}
