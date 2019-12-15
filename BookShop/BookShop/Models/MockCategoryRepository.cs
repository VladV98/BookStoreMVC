using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Computer books", Description="All-computer books"},
                new Category{CategoryId=2, CategoryName="Science books", Description="All-science books"},
                new Category{CategoryId=3, CategoryName="Technical books", Description="All-technical books"}
            };
    }
}
