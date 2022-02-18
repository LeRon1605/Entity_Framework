using Microsoft.EntityFrameworkCore;
namespace EF_Practice
{
    class StudentDbContext: DbContext
    {
        private string connectionString = "Server=localhost,1433;Database=StudentDB;UID=sa;PWD=ronle75";

        public DbSet<Student> students {get; set;}
        public DbSet<Subject> subjects {get; set;}

        public DbSet<Class> classes {get; set;}
        public DbSet<Teacher> teachers {get; set;}
        public DbSet<StudentSubject> student_subjects {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        
            builder.Entity<Student>(entity => {
                entity.HasOne(student => student.classRoom)
                      .WithMany(classRoom => classRoom.students)
                      .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}