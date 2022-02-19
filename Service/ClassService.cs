namespace EF_Practice
{
    class ClassService
    {
        public static async Task<Class> getClass(int classID)
        {
            StudentDbContext context = new StudentDbContext();
            Class classroom = await context.classes.FindAsync(classID);
            return classroom;

        }
        public static async Task addStudent(int classID, int studentID)
        {
            StudentDbContext context = new StudentDbContext();
            Class classroom = await context.classes.FindAsync(classID);
            if (classroom != null)
            {
                Student student = await context.students.FindAsync(studentID);
                if (student != null)
                {
                    student.classRoom = classroom;
                    context.SaveChanges();
                }
            }
        }
    }
}