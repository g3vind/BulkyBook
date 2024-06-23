using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<CategoryModel> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel { Id = 1, Name = "Action", DisplayOrder = 1, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 2, Name = "Science Fiction", DisplayOrder = 2, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 3, Name = "Romance", DisplayOrder = 3, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 4, Name = "Mystery", DisplayOrder = 4, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 5, Name = "Fantasy", DisplayOrder = 5, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 6, Name = "Horror", DisplayOrder = 6, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 7, Name = "Thriller", DisplayOrder = 7, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 8, Name = "Historical Fiction", DisplayOrder = 8, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 9, Name = "Biography", DisplayOrder = 9, CreatedAt = DateTime.Now },
                new CategoryModel { Id = 10, Name = "Self-Help", DisplayOrder = 10, CreatedAt = DateTime.Now }
            );
        }


    }
}
