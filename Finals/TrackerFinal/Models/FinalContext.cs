using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace TrackerFinal.Models
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options)
        : base(options)
        { }
        public DbSet<Student> Students { get; set; }
    }
}
