using System.Collections.Generic;
using System.Linq;
using Demo1.Entities;
using Demo1.Repositories.Base;

namespace Demo1.Repositories
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name = "Strawberry pie", Price = 15.95m, ShortDescription = "Lorem Ipsum"},
                new Pie {PieId = 2, Name = "Cheese cake", Price = 18.95m, ShortDescription = "Lorem Ipsum"},
                new Pie {PieId = 3, Name = "Rhubarb pie", Price = 15.95m, ShortDescription = "Lorem Ipsum"},
                new Pie {PieId = 4, Name = "Pumpkin pie", Price = 12.95m, ShortDescription = "Lorem Ipsum"}
            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}