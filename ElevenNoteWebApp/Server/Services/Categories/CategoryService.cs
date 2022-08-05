using ElevenNoteWebApp.Server.Data;
using ElevenNoteWebApp.Server.Models;
using ElevenNoteWebApp.Shared.Models.Category;
using Microsoft.EntityFrameworkCore;

namespace ElevenNoteWebApp.Server.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCategoryAsync(CategoryCreate model)
        {
            if (model == null) return false;
            var categoryEntity = new Category
            {
                Name = model.Name
            };
            _context.Categories.Add(categoryEntity);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<CategoryListItem>> GetAllCategoriesAsync()
        {
            var categoryQuery =
                _context
                .Categories
                .Select(entity =>
                new CategoryListItem
                {
                    Id = entity.Id,
                    Name = entity.Name
                });

            return await categoryQuery.ToListAsync();
        }

        public Task<CategoryDetail> GetCategoryByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(CategoryEdit model)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
