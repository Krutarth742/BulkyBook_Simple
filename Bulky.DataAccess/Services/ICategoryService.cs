using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryModel>> GetCategories();
        Task<CategoryModel?> GetCategory(int? categoryID);
        Task InsertCategory(CategoryModel category);
        Task UpdateCategory(CategoryModel category);
        Task DeleteCategory(CategoryModel category);
        Task SaveCategory();
    }
}
