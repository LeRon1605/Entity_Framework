using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practice
{
    [Table("Student")]
    class Student: Person
    {
        public Class? classRoom { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}