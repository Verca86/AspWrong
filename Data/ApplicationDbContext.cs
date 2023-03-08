using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspWrong.Models;
using AspWrong.Views.Home;

namespace AspWrong.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Article1> Article1 { get; set; } = default!;
        public DbSet<Article2> Article2 { get; set; } = default!;
        public DbSet<Pojistka> Pojistka { get; set; } = default!;

    }
}