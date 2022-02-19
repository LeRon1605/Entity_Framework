using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practice
{
    [Table("Student")]
    class Student : Person
    {
        public int? classRoomID { get; set; }
        public Class? classRoom { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override async Task input()
        {
            base.input();
            Console.Write("Class: ");
            int classID = Convert.ToInt32(Console.ReadLine());
            classRoom = await ClassService.getClass(classID);
            while (classRoom == null)
            {
                Console.Write("Class does not exist, type again: ");
                classID = Convert.ToInt32(Console.ReadLine());
                // await ClassService.addStudent(classID, ID);
                classRoom = await ClassService.getClass(classID);
            }
        }

    }
}