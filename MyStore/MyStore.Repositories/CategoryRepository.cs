namespace MyStore.Repositories;
using MyStore.Business;
using MyStore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
public class CategoryRepository : ICategoryRepository
{
    private readonly MyStoreDbContext _context;
    
    public CategoryRepository(MyStoreDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Category>> GetAllAsync(int currentPage , int pageSize )
    {
        // Phan trang du lieu
        //currentPage: trang hien tai
        //pageSize: so luong du lieu tren mot trang
        return await _context.Categories.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
       
    }

    public async Task<Category?> GetByIdAsync(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task<Category?> GetByNameAsync(string name)
    {
        return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryName == name);
    }

    public async Task<Category> AddAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;

    }
    public async Task<Boolean> AddRangeAsync(IEnumerable<Category> categories) {
        _context.Categories.AddRange(categories);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        _context.Entry(category).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var category = await GetByIdAsync(id);
        if (category == null) return false;

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.Categories.AnyAsync(c => c.CategoryId == id);
    }

    public async Task<bool> ExistsByNameAsync(string name)
    {
        return await _context.Categories.AnyAsync(c => c.CategoryName == name);
    }
}
   