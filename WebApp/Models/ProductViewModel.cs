using DataService.Models;
using System.Collections.Generic;

namespace DempApp.Models
{
    public class ProductViewModel:Product
    {
        public ProductViewModel()
        {
            this.GetProducts = new List<Product>();
        }
        public List<Product> GetProducts { get; set; }
    }
}