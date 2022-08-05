using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteWebApp.Shared.Models.Note
{
    public class NoteDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
