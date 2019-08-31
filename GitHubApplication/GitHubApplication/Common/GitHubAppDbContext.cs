using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace GitHubApplication.Common
{
    public class GitHubAppDbContext : DbContext
    {
        public GitHubAppDbContext()
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\GitHubApp.db");
        }


        public DbSet<User> Users { get; set; }
        public DbSet<ProgrammingLanguage> Languages { get; set; }
        public DbSet<LanguageStatistics> StarsStatistics { get; set; }
    }
}
