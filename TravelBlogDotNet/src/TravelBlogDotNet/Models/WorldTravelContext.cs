using Microsoft.EntityFrameworkCore;

namespace TravelBlogDotNet.Models
{
    public class WorldTravelContext : DbContext
    {
        public virtual DbSet<Experience> Experiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WorldTravel;integrated security=True");
        }
    }
}