using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
    public class HairSalonContext : DbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Stylist> Stylists { get; set; }
        public HairSalonContext(DbContextOptions options) : base(options) { }
    }
}