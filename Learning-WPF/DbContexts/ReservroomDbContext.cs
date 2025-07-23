using Learning_WPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_WPF.DbContexts
{
    public class ReservroomDbContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
    }
}
