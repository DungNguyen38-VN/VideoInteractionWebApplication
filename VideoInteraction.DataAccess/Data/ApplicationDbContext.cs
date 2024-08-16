using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoInteraction.Models;

namespace VideoInteraction.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<CameraControlTag> CameraControlTags { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<MeasurementPrefix> measurementPrefixes { get; set; }
        public DbSet<MeasurementTag> MeasurementTags { get; set; }
        public DbSet<Window> Windows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Camera>().HasData(
                new Camera { Id = 1, Name = "Cam01", CameraCode = "code12312001", Description = "", CreatedTs = DateTime.Now },
                new Camera { Id = 2, Name = "Cam02", CameraCode = "code12312002", Description = "", CreatedTs = DateTime.Now },
                new Camera { Id = 3, Name = "Cam03", CameraCode = "code12312003", Description = "", CreatedTs = DateTime.Now }
                );
            modelBuilder.Entity<CameraControlTag>().HasData(
                new CameraControlTag { Id = 1, TagName = "TDC_Com.TDC1.Tag1", Description = "tag1", CreatedTs = DateTime.Now, UpdatedTs = DateTime.Now, CameraId = 1 },
                new CameraControlTag { Id = 2, TagName = "TDC_Com.TDC1.Tag2", Description = "tag2", CreatedTs = DateTime.Now, UpdatedTs = DateTime.Now, CameraId = 2 },
                new CameraControlTag { Id = 3, TagName = "TDC_Com.TDC1.Tag3", Description = "tag3", CreatedTs = DateTime.Now, UpdatedTs = DateTime.Now, CameraId = 3 },
                new CameraControlTag { Id = 4, TagName = "TDC_Com.TDC1.Tag4", Description = "tag4", CreatedTs = DateTime.Now, UpdatedTs = DateTime.Now, CameraId = 4 }
                );
        }
    }
}
