using System.Collections.Generic;
using Demo1.Entities;

namespace Demo1.Repositories.Base
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get;  }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}