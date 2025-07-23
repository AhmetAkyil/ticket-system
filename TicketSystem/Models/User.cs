using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

    }
}
