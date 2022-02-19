namespace EF_Practice
{
    class SubjectService
    {

        public static async Task<List<Student>> getListStudentsOfSubject(int subjectID)
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
                return students.ToList();
            }else {
                Console.WriteLine("Subject does not exist");
                return null;
            }
        }

        public static async Task<Teacher> getTeacherOfSubject(int subjectID)
        {
            StudentDbContext context = new StudentDbContext();
            Subject subject = await context.subjects.FindAsync(subjectID);
            if (subject != null)
            {
                var entry = context.Entry(subject);
                entry.Reference(e => e.teacher).Load();
                return subject.teacher;
            }else {
                Console.WriteLine("Subject does not exist");
                return null;
            }
        }
    }
}