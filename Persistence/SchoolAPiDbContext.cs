using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;
namespace SchoolApi.Persistence
{
    public class SchoolAPiDbContext : DbContext
    {
        public DbSet<UserModel> user { get; set; }

        public DbSet<UserDetailsModel> userDetailsDB { get; set; }

        public DbSet<Photos> photosDB { get; set; }

        public DbSet<StudentModel> detailDB { get; set; }

        public DbSet<StudentAttendanceModel> attendanceDB { get; set; }

        

        


        public SchoolAPiDbContext(DbContextOptions<SchoolAPiDbContext> options )
        : base(options)
        {
            
        }

        protected override void  OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudDetailAttendanceModel>().HasKey(sd =>
                new {
                        sd.StudentDetailsModelId,
                        sd.StudentAttendanceModelId
                    }
            );
        }

        
        
    }
}