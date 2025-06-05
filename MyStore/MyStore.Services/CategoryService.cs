namespace Mystore.Services;
using MyStore.Business;
using Mystore.Services.Interfaces;
using MyStore.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<IEnumerable<Category>> GetAllAsync(int currentPage, int pageSize)
    {
        return await _categoryRepository.GetAllAsync(currentPage, pageSize);
    }

    public async Task<Category?> GetByIdAsync(int id)
    {
        return await _categoryRepository.GetByIdAsync(id);
    }

    public async Task<Category?> GetByNameAsync(string name)
    {
        return await _categoryRepository.GetByNameAsync(name);
    }

    public async Task<Category> AddAsync(Category category)
    {
        return await _categoryRepository.AddAsync(category);
    }

    public async Task<bool> AddRangeAsync(IEnumerable<Category> categories)
    {
        return await _categoryRepository.AddRangeAsync(categories);
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        return await _categoryRepository.UpdateAsync(category);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _categoryRepository.DeleteAsync(id);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _categoryRepository.ExistsAsync(id);
    }

    public async Task<bool> ExistsByNameAsync(string name)
    {
        return await _categoryRepository.ExistsByNameAsync(name);
    }
}