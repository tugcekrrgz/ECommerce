using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.Entity.Entity;

namespace ECommerce.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> _categoryRepository;


        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }



        public string Create(Category entity)
        {
            return _categoryRepository.Create(entity); 
        }

        public string Delete(int id)
        {
            return _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public string Update(Category entity)
        {
            return _categoryRepository.Update(entity);
        }
    }
}
