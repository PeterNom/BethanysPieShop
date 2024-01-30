
namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbcontext;

        public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbcontext)
        {
            _bethanysPieShopDbcontext = bethanysPieShopDbcontext;
        }

        public IEnumerable<Category> AllCategories => _bethanysPieShopDbcontext.Categories.OrderBy(p => p.CategoryName);
    }
}
