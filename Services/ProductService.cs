using ProductManager.Data;
using ProductManager.Models;

namespace ProductManager.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private IProductAccess productAccess;

        public ProductService(ILogger<ProductService> logger, IProductAccess productAccess)
        {
            _logger = logger;
            this.productAccess = productAccess;
        }

        public void Create(Product product)
        {
            productAccess.Create(product);
        }

        public Product GetById(int? id)
        {
            var product = productAccess.GetById(id);
            return product;
        }

        public List<Product> List()
        {
            var products = productAccess.List();
            return products;
        }

        public int Remove(int? id)
        {
            return productAccess.Remove(id);
        }

        public int Update(int? id, Product product)
        {
            return productAccess.Update(id, product);
        }
    }
}
