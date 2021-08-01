using System.Collections.Generic;
using Demo1.DataAccess;
using Demo1.Entities;
using Demo1.Repositories.Base;

namespace Demo1.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}