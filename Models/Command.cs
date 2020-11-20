using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required] // Changes migrationBuilder so that nullable is false 
        [MaxLength(250)] // Constraint on the maxnum of chars in the string
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }

    }
}