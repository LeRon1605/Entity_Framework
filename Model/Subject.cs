using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practice
{
    [Table("Subject")]
    class Subject
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("Name", TypeName = "ntext")]
        [MaxLength(60)]
        public string name { get; set; }
        
        [Required]
        [Column("Credit", TypeName = "int")]
        public int credit { get; set; }

        [Required]
        [Column("Start_Date", TypeName = "DateTime")]
        [DataType(DataType.DateTime)]
        public DateTime startDate { get; set; }

        [Required]
        [Column("End_Date", TypeName = "DateTime")]
        [DataType(DataType.DateTime)]
        public DateTime endDate { get; set; }
        public Teacher? teacher { get; set; }

    }
}