using Microsoft.EntityFrameworkCore;
namespace EF_Practice
{
    class TeacherService
    {
        public static async Task<Teacher> getTeacher(int teacherID)
        {
            StudentDbContext context = new StudentDbContext();
            Teacher teacher = await context.teachers.FindAsync(teacherID);
            Console.WriteLine(teacher);
            return teacher;
        }
        public static async Task teach(int teacherID, int subjectID)
        {
            StudentDbContext context = new StudentDbContext();
            Teacher teacher = await context.teachers.FindAsync(teacherID);
            if (teacher != null)
            {
                Subject subject = await context.subjects.FindAsync(subjectID);
                if (subject != null)
                {
                    teacher.subjects.Add(subject);
                    context.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("Teacher does not exist");
            }
        }

    }
}