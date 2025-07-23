using Microsoft.EntityFrameworkCore;
using TicketSystem.Models;

namespace TicketSystem.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
