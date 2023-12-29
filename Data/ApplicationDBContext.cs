using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Data
{
    public class ApplicationDbContext : DbContext



    {
        
        
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
            public DbSet<Polikinlik> Polikinlikler { get; set; }
            public DbSet<Doctor> Doktorlar { get; set; }
            public DbSet<Address> Addresses { get; set; }
            
        }
    }



