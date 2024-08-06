using Microsoft.AspNetCore.Mvc;
using ProductManager.Data;
using ProductManager.Models;

namespace ProductManager.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private IProductAccess productAccess;

        public ProductsController(ILogger<ProductsController> logger, IProductAccess productAccess)
        {
            _logger = logger;
            this.productAccess = productAccess;
        }

        [HttpGet]
        public List<Product> Get()
        {
            var products = productAccess.List();
            return products;
        }

        [HttpPost]
        public void CreateProduct(Product product)
        {
            productAccess.Create(product);
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = productAccess.GetById(id);
            return product;
        }

        [HttpPut("{id}")]
        public int UpdateProduct(int id, Product product)
        {
            return productAccess.Update(id, product);
        }

        [HttpDelete("{id}")]
        public int RemoveProduct(int id)
        {
            return productAccess.Remove(id);
        }

    }
}
