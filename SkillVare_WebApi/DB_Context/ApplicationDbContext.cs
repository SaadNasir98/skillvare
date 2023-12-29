using Microsoft.EntityFrameworkCore;
using SkillVare_WebApi.Models;

namespace SkillVare_WebApi.DB_Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Skills> Skills { get; set; }
        public DbSet<SkillCategory> SkillCategory { get; set; }
        public DbSet<CVTemplate> CVTemplate { get; set; }
        public DbSet<User_Resume> User_Resume { get; set; }
        public DbSet<User_Resume_Page> User_Resume_Page { get; set; }
        public DbSet<User_Skills> User_Skills { get; set; }

    }
}
