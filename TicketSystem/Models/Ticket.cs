using System.ComponentModel.DataAnnotations;
using TicketSystem.Enums;

namespace TicketSystem.Models
{
    public class Ticket
    {
        [Key]
        public long TicketId { get; set; }
        
        [Required]
        public string Title { get; set; }   
        public string Description { get; set; }
        [Required]
        public TicketStatus Status { get; set; }

        public long CreatedByUserId { get; set; }
        public long? AssignedToUserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
