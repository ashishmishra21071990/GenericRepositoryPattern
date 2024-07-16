using GenericRepostoryPatternCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepostoryPatternCore.Services
{
    public class GenericDbContext:DbContext
    {
        public GenericDbContext(DbContextOptions<GenericDbContext> options):base(options)
        {

        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
