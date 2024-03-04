using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Services;
using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _dbCategory;
        public CategoryService(ApplicationDbContext dbCategory) /*: base(db)*/
        {
            _dbCategory = dbCategory;
        }

        public Task<List<CategoryModel>> GetCategories()
        {
            IQueryable<CategoryModel> query = _dbCategory.Set<CategoryModel>();
            return query.ToListAsync();
        }

        public async Task<CategoryModel?> GetCategory(int? categoryID)
        {
            return await _dbCategory.Set<CategoryModel>().Where(c => c.CategoryID == categoryID).FirstOrDefaultAsync();
        }

        public async Task InsertCategory(CategoryModel category)
        {
            await _dbCategory.AddAsync(category);
        }

        public async Task UpdateCategory(CategoryModel category)
        {
            await Task.Run(() => _dbCategory.Update(category));
        }
        public async Task DeleteCategory(CategoryModel category)
        {
            await Task.Run(() => _dbCategory.Remove(category));
        }

        public async Task SaveCategory()
        {
            await _dbCategory.SaveChangesAsync();
        }
    }
}
