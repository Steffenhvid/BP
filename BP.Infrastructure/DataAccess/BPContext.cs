using BP.Infrastructure.DataAccess.ModelExtensions;
using BP.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BP.Infrastructure.DataAccess
{
    public class BPContext : DbContext
    {
        public DbSet<DeveloperEntity> Developers { get; set; }
        public DbSet<SkillEntity> Skills { get; set; }
        public DbSet<AdressEntity> Adresses { get; set; }

        public BPContext(DbContextOptions<BPContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureDeveloperEntity<DeveloperEntity>();
            modelBuilder.ConfigureSkillEntity<SkillEntity>();
            modelBuilder.ConfigureAdressEntity<AdressEntity>();
            base.OnModelCreating(modelBuilder);
        }
    }
}