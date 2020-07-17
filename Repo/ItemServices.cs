using DataService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryService
{
    public interface IProductServices
    {
        public  Task<List<Product>> GetProductList();
        public Task SaveProduct(Product product);

    }
    public class ProductServices:IProductServices
    {

        private ProductContext context;

        public ProductServices(ProductContext _context)
        {
            context = _context;
        }
        public async Task SaveProduct(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }
        public async  Task<List<Product>> GetProductList()
        {
            return await this.context.Products.ToListAsync();

        }


    }
}
