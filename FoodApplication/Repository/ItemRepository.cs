using FoodApplication.Contracts;
using FoodApplication.Data;

namespace FoodApplication.Repository;

public class ItemRepository : GenericRepository<Item>, IItemRepository
{
    public ItemRepository(FoodDBContext context) : base(context)
    {
    }
}