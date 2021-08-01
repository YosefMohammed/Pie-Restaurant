using System.Collections.Generic;
using Demo1.Entities;
using Demo1.Repositories.Base;

namespace Demo1.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Fruit pies", Description = "All-fruity pies"},
                new Category {CategoryId = 2, CategoryName = "Cheese cakes", Description = "Cheesy all ahe way"},
                new Category {CategoryId = 3, CategoryName = "Seasonal pies", Description = "Get in the mood for seasonal pies"}
            };
    }
}