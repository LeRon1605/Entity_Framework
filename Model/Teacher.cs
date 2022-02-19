using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF_Practice
{
    [Table("Teacher")]
    class Teacher: Person
    {
        public List<Subject>? subjects {get; set;}

        [ForeignKey("classID")]
        public int? classID { get; set; }
        public Class classRoom { get; set; }
    }
}