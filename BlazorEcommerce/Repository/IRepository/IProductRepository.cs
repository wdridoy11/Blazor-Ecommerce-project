using BlazorEcommerce.Data;
using Microsoft.CodeAnalysis;

namespace BlazorEcommerce.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Project obj);
        public Task<Product> UpdateAsync(Project obj);
        public Task<bool> DeleteAsync(int id);
        public Task<Product> GetAsync(int id);
        public Task<IEnumerable<Product>> GetAllAsync();
    }
}
