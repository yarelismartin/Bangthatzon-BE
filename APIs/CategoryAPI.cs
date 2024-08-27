

namespace Bangthatzon.APIs
{
    public class CategoryAPI
    {
        public static void Map(WebApplication app)
        {
            //get all categories
            app.MapGet("/api/categories", (BangthatzonDbContext db) =>
            {
                return db.Categories.ToList();
            });

        }
    }
}
