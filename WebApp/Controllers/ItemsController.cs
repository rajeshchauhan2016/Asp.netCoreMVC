using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService.Models;
using DempApp.Models;
using Microsoft.AspNetCore.Mvc;
using RepositoryService;

namespace DempApp.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext context;
        private IProductServices productServices;
        public ProductController(ProductContext _context, IProductServices _productServices)
        {
            context = _context;
            productServices = _productServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            
            return View(new ProductViewModel { GetProducts = await this.productServices.GetProductList() });
            
        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct(ProductViewModel product)
        {
            try
            {

                await this.productServices.SaveProduct(product);
                product.GetProducts = await this.productServices.GetProductList();
                return View("AddProduct", product);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}