using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteWebApp.Shared.Models.Note
{
    public class NoteListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
