using Bangthatzon.Models;

namespace Bangthatzon.Data
{
    public class CategoryData
    {
        public static List<Category> Categories = new List<Category>
        {
            new Category { Id = 1, CategoryName = "Electronics" },
            new Category { Id = 2, CategoryName = "Clothing" },
            new Category { Id = 3, CategoryName = "Home & Kitchen" },
            new Category { Id = 4, CategoryName = "Books" },
            new Category { Id = 5, CategoryName = "Sports & Outdoors" },
        };
    }
}
