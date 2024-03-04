using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAccess.Services;
using BulkyBook.Models;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    // Define Area and Authorize role.
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        // Instance of Dependency Injection
        //private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryService _categoryService;
        public CategoryController(/*IUnitOfWork unitOfWork*/  ICategoryService categoryService)
        {
            //_unitOfWork = unitOfWork;
            _categoryService = categoryService; 
        }

        #region Display Category
        public async Task<IActionResult> Index()
        {
            // Retrieve list of Category
            List<CategoryModel> categoryList = await _categoryService.GetCategories();
            return View(categoryList);
        }
        #endregion

        #region Create Category
    
        // Handle GET request
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryModel category)
        {
            // If model is bound then create a category 
            if (ModelState.IsValid)
            {
                await _categoryService.InsertCategory(category);
                await _categoryService.SaveCategory();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Edit Category
        public async Task<IActionResult> EditCategory(int? categoryID)
        {
            // CategoryID Validation
            if (categoryID == null || categoryID < 0)
            {
                return NotFound();
            }

            // Use Repository Get method
            CategoryModel? categoryFromDb = await _categoryService.GetCategory(categoryID);
            
            // Example of FirstOrDefault Method
            // CategoryModel? categoryFromDb1 = _dbCategory.Categories.FirstOrDefault(u=>u.CategoryID == categoryID);

            // Example of FirstOrDefault with Where Clause
            // CategoryModel? categoryFromDb2 = _dbCategory.Categories.Where(u => u.CategoryID == categoryID).FirstOrDefault();

            // Check if data is found or not
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryModel categoryObj)
        {
            // If model is bound then edit a category
            if (ModelState.IsValid)
            {
                await _categoryService.UpdateCategory(categoryObj);
                await _categoryService.SaveCategory();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Delete Category
        public async Task<IActionResult> DeleteCategory(int? categoryID)
        {
            // Check CategoryID Validations
            if (categoryID == null || categoryID < 0)
            {
                return NotFound();
            }

            // Retrieve Category using Get Method
            CategoryModel? categoryFromDb = await _categoryService.GetCategory(categoryID);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        // Define custom ActionName to maintain naming in View
        [HttpPost, ActionName("DeleteCategory")]
        public async Task<IActionResult> DeleteCategoryPOST(int? categoryID)
        {
            CategoryModel? categoryObj = await _categoryService.GetCategory(categoryID);
            if (categoryObj == null)
            {
                return NotFound();
            }
            await _categoryService.DeleteCategory(categoryObj);
            await _categoryService.SaveCategory();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
        #endregion
    }
}
