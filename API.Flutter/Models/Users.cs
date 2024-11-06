using System.ComponentModel.DataAnnotations;

namespace API.Flutter.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";

        [Required]
        [MaxLength(150)]
        public string Address { get; set; } = "";

    }
}
