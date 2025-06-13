using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoInteraction.Models;
using VideoInteraction.Models.HIK;
using Monitor = VideoInteraction.Models.HIK.Monitor;

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
        public DbSet<MeasurementPrefix> MeasurementPrefixes { get; set; }
        public DbSet<MeasurementTag> MeasurementTags { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<ControlWindowTag> ControlWindowTags { get; set; }
        public DbSet<ShowStringParam> ShowStringParams { get; set; }
        public DbSet<TvWallScene> TvWallScenes { get; set; }
        public DbSet<AlarmMessage> AlarmMessages { get; set; }
        public DbSet<CameraAlarmTag> CameraAlarmTags { get; set; }
        public DbSet<CameraVideoDownload> CameraVideoDownloads { get; set; }

        //HIK tables
        public DbSet<TvWall> TvWalls { get; set; }
        public DbSet<Dlp> Dlps { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<FloatWnd> FloatWnds { get; set; }
        public DbSet<Wnd> Wnds { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TvWallScene>().ToTable("TvWallScenes");
            modelBuilder.Entity<CameraVideoDownload>().ToTable("CameraVideoDownloads");

            //migration table to hik schema
            modelBuilder.Entity<TvWall>().ToTable("TvWall", "hik");
            modelBuilder.Entity<Dlp>().ToTable("Dlp", "hik");
            modelBuilder.Entity<Monitor>().ToTable("Monitor", "hik");
            modelBuilder.Entity<FloatWnd>().ToTable("FloatWnd", "hik");
            modelBuilder.Entity<Wnd>().ToTable("Wnd", "hik");
            modelBuilder.Entity<Group>().ToTable("Group", "hik");
        }
    }
}
