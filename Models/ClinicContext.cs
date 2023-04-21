//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ClinicContext : DbContext
    {
        //private const string V = "MyClinic";

        public ClinicContext() : base()
        {

        }

        public DbSet<role>? Roles { get; set; }

        public DbSet<user>? Users { get;set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=IN05N0018F ;Integrated Security=true ; TrustServerCertificate=true");
        }*/
    }
}
