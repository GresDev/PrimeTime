using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using PrimeTime.Utils;

namespace PrimeTime.Models
{
    public sealed class AppDbContext : IdentityDbContext
    {
        private readonly IStringLocalizer<SkillLevel> _localizer;
        public AppDbContext(DbContextOptions<AppDbContext> options, IStringLocalizer<SkillLevel> localizer) : base(options)
        {
            _localizer = localizer;
            Database.Migrate();
        }

        public DbSet<SkillLevel> SkillLevels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed(_localizer);
        }
    }
}
