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
        public DbSet<CV_Template> CV_Template { get; set; }
        public DbSet<User_Resume> user_Resumes { get; set; }

    }
}
