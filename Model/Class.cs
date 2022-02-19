using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practice
{
    [Table("Class")]
    class Class
    {
        [Key]
        public int ID {get; set; }

        [Column("Name", TypeName = "ntext")]
        [Required]
        [MaxLength(20)]
        public string name { get; set; }
        public List<Student> students { get; set; }
        public Teacher teacher { get; set; }

        public void input() { 
            Console.Write("Name: ");
            name = Console.ReadLine();
        }
    }
}