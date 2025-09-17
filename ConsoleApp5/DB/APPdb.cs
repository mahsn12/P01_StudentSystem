using P01_StudentSystem.model;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.model;

namespace ConsoleApp5.DB
{
    public class APPdb : DbContext
    {
        DbSet<Course> courses { set; get; }
        DbSet<Students> students { set; get; }
        DbSet<HomeWorkSubmissions>HW { set; get; }
        DbSet<Resources>resources { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Database=Task1;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"
            );
        }
    }
}
