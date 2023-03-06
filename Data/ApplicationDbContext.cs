using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AspWrong.Models;

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
    }
}