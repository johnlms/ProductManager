using Microsoft.AspNetCore.Mvc;
using ProductManager.Data;
using ProductManager.Models;
using ProductManager.Services;

namespace ProductManager.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private IProductService productService;

        public ProductsController(ILogger<ProductsController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            var products =  productService.List();
            return products;
        }

        [HttpPost]
        public void CreateProduct(Product product)
        {
            productService.Create(product);
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = productService.GetById(id);
            return product;
        }

        [HttpPut("{id}")]
        public void UpdateProduct(int id, Product product)
        {
            productService.Update(id, product);
        }

        [HttpDelete("{id}")]
        public void RemoveProduct(int id)
        {
            productService.Remove(id);
        }

    }
}
