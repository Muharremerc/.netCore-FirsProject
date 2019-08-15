using DrinkETic.Data.Interfaces;
using DrinkETic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkETic.Data
{
    public class TestCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1,CategoryName="A",Description="TestCategory"},
                    new Category{CategoryId=2,CategoryName="B",Description="TestCategory"}
                };
            }
        }

    }
}
