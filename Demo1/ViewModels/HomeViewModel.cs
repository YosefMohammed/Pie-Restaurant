using System.Collections.Generic;
using Demo1.Entities;

namespace Demo1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}