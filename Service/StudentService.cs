namespace EF_Practice
{
    class StudentService
    {
        public static async Task registerSubject(int studentID, int subjectID)
        {
            StudentDbContext context = new StudentDbContext();
            Student student = await context.students.FindAsync(studentID);
            if (student != null)
            {
                Subject subject = await context.subjects.FindAsync(subjectID);
                if (subject != null)
                {
                    context.student_subjects.Add(new StudentSubject {
                        student = student,
                        subject = subject
                    });
                    int affectedRow = await context.SaveChangesAsync();
                    Console.WriteLine($"{affectedRow} row affected");
                }
                else Console.WriteLine($"Subject does not exist");
            }
            else Console.WriteLine($"Student does not exist");
        }
    }
}