//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace CFDemo
{
    internal partial class Program
    {
        public class BlogContext : DbContext 
        {
            /*public BlogContext(DbContextOptions<BlogContext> options) : base(options)
            {

            }*/
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }

            /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDb ;Integrated Security=true" );
            }*/
        }
    }
}