using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ProductInventory> Products { get; set; }

    }
}
