using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Practice
{
    class Person
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name must not be null.")]
        [Column("Name", TypeName = "ntext")]
        [MaxLength(30)]
        public string name { get; set; }

        [Column("Email", TypeName = "ntext")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(30)]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [Column("Gender", TypeName = "ntext")]
        [RegularExpression("Male|Female", ErrorMessage = "Invalid Gender")]
        public string gender { get; set; }

        [Column("Address", TypeName = "ntext")]
        [MaxLength(30)]
        public string address { get; set; }

        [Column("PhoneNumber", TypeName = "ntext")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string phoneNumber { get; set; }

        public override string ToString()
        {
            return $"{ID, -10}{name, -20}{gender, -10}{address, -20}{email, -20}{phoneNumber}";
        }
    }
}