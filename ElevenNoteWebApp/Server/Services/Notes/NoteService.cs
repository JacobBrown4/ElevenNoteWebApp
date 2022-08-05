using ElevenNoteWebApp.Server.Data;
using ElevenNoteWebApp.Server.Models;
using ElevenNoteWebApp.Shared.Models.Note;

namespace ElevenNoteWebApp.Server.Services.Notes
{
    public class NoteService : INoteService
    {
        private readonly ApplicationDbContext _context;
        private string _userId;
        public NoteService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateNoteAsync(NoteCreate model)
        {
            Note noteEntity = new Note
            {
                Title = model.Title,
                Content = model.Content,
                OwnerId = _userId,
                CreatedUtc = DateTimeOffset.Now,
                CategoryId = model.CategoryId
            };

            _context.Notes.Add(noteEntity);
            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public Task<bool> DeleteNoteAsync(int noteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNoteAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NoteListItem>> GetAllNotesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NoteDetail> GetNoteByIdAsync(int noteId)
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateNoteAsync(NoteEdit model)
        {
            throw new NotImplementedException();
        }
        public void SetUserId(string userId) => _userId = userId;
    }
}
