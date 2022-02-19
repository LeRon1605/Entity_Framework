namespace EF_Practice
{
    class StudentService
    {
        public static async Task showStudents()
        {
            StudentDbContext context = new StudentDbContext();
            Console.WriteLine($"{"ID", -10}{"Name", -20}{"Gender", -10}{"Address", -20}{"Email", -20}{"PhoneNumber"}");
            context.students.ToList().ForEach(student => Console.WriteLine(student.ToString()));
        }
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
        public static async Task removeStudent(int studentID)
        {
            StudentDbContext context = new StudentDbContext();
            Student student = await context.students.FindAsync(studentID);
            if (student != null) context.students.Remove(student);
            else Console.WriteLine($"Student does not exist.");
        }

        public static async Task showListSubject(int studentID)
        {
            StudentDbContext context = new StudentDbContext();
            Student student = await context.students.FindAsync(studentID);
            var subjects = context.student_subjects.ToList().Where(record => record.student == student).Select(record => {
                var entry = context.Entry(record);
                entry.Reference(e => e.subject).Load();

                var _entry = context.Entry(record.subject);
                _entry.Reference(e => e.teacher).Load();
                return record.subject;
            });
            Console.WriteLine($"{"ID", -10}{"Name", -30}{"Credit", -8}{"Start Date", -30}{"End Date", -30}{"Teacher"}");
            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject.ToString());
            }
        }
    }
}