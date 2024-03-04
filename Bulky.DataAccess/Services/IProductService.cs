using BulkyBook.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Services
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProducts();
        Task<ProductModel?> GetProduct(int? ProductID);
        Task InsertProduct(IFormFile image, string productDetailsJson);
        Task UpdateProduct(IFormFile image, string productDetailsJson, int productId);
        Task DeleteProduct(ProductModel Product);
        Task SaveProduct();
    }
}
