using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.Entity.Entity;

namespace ECommerce.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository) 
        {
            _productRepository = productRepository;
        }
        public string Create(Product entity)
        {
            return _productRepository.Create(entity);
        }

        public string Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public string Update(Product entity)
        {
            return _productRepository.Update(entity);
        }

        //custom methods

    }
}
