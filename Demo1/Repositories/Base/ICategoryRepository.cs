using System.Collections.Generic;
using Demo1.Entities;

namespace Demo1.Repositories.Base
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}