using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practice
{
    [Table("StudentSubject")]
    class StudentSubject
    {
        [Key]
        public int ID { get; set; }
        public Student student { get; set; }
        public Subject subject { get; set; }
    }
}