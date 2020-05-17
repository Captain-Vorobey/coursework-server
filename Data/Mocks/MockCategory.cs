using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category { id = 1, name = "Gucci"},
                    new Category { id = 2, name = "Louis Vuitton" },
                    new Category { id = 3, name = "Hermes" },
                    new Category { id = 4, name = "Armani" },
                    new Category { id = 5, name = "Chanel" }
                };
            }
        }
    }
}
