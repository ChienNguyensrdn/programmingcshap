namespace Mystore.Services.Interfaces;
using MyStore.Business;
using System.Collections.Generic;
using System.Threading.Tasks;
public interface ICategoryService
{
    //CRUD Object ....
    Task<IEnumerable<Category>> GetAllAsync(int currentPage, int pageSize);
    Task<Category?> GetByIdAsync(int id);
    Task<Category?> GetByNameAsync(string name);
    Task<Category> AddAsync(Category category);
    Task<bool> AddRangeAsync(IEnumerable<Category> categories);
    Task<Category> UpdateAsync(Category category);
    Task<bool> DeleteAsync(int id);
    Task<bool> ExistsAsync(int id);
    Task<bool> ExistsByNameAsync(string name);
}