using System.ComponentModel.DataAnnotations;

namespace ElevenNoteWebApp.Server.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModiefiedUtc { get; set; }
    }
}
