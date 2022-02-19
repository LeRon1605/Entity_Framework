using Microsoft.EntityFrameworkCore;
namespace EF_Practice
{
    class DBService
    {
        public static async Task createDB()
        {
            StudentDbContext context = new StudentDbContext();
            bool result = await context.Database.EnsureCreatedAsync();
            if (result) Console.WriteLine($"Successfully created DB {context.Database.GetDbConnection().Database}");
            else Console.WriteLine($"Failure created DB {context.Database.GetDbConnection().Database}");
        }

        public static async Task deleteDB()
        {
            StudentDbContext context = new StudentDbContext();
            bool result = await context.Database.EnsureDeletedAsync();
            if (result) Console.WriteLine($"Successfully deleted DB {context.Database.GetDbConnection().Database}");
            else Console.WriteLine($"Failure deleted DB {context.Database.GetDbConnection().Database}");
        }

        public static async Task Add(object obj)
        {
            StudentDbContext context = new StudentDbContext();

            if (!Validate.validate(obj)) return;

            if (obj is Student) context.students.Add((Student)obj);
            else if (obj is Subject) context.subjects.Add((Subject)obj);
            else if (obj is Class) context.classes.Add((Class)obj);
            else if (obj is Teacher) context.teachers.Add((Teacher)obj);
            int affectedRow = await context.SaveChangesAsync();
            Console.WriteLine($"{affectedRow} row affected");
        }
    }
}