using FoodApplication.Contracts;
using FoodApplication.Data;

namespace FoodApplication.Repository;

public class CartRepository : GenericRepository<Cart>, IICartRepository
{
    public CartRepository(FoodDBContext context) : base(context)
    {
    }
}