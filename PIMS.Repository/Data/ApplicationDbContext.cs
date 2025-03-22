using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PIMS.Models;

namespace PIMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<LocalBody> LocalBody { get; set; }
        public DbSet<LocalBodyType> LocalBodyType { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<PrisonInfromation> PrisonInfromation { get; set; }

    }
}
