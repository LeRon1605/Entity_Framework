namespace EF_Practice
{
    class SubjectService
    {
        public static async Task getListStudentsOfSubject(int subjectID)
        {
            StudentDbContext context = new StudentDbContext();
            Subject subject = await context.subjects.FindAsync(subjectID);
            if (subject != null)
            {
                var students = context.student_subjects.ToList().Where(record => record.subject == subject).Select(record =>
                {
                    var entry = context.Entry(record);
                    entry.Reference(e => e.student).Load();
                    return record.student;
                });
                Console.WriteLine($"{"ID",-10}{"Name",-20}{"Gender",-10}{"Address",-20}{"Email",-20}{"PhoneNumber"}");
                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                }
            }else Console.WriteLine("Subject does not exist");
        }
    }
}