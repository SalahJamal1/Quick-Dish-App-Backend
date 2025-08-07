using FoodApplication.Models.Carts;

namespace FoodApplication.Models.Orders;

public class OrderBase
{
    public ICollection<CartBase> Carts { get; set; } = new List<CartBase>();
    public float OrderPrice { get; set; }
    public Status Status { get; set; }
    public DateTime EstimatedDelivery { get; set; } = DateTime.UtcNow.AddMinutes(15);
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ActualDelivery { get; set; }
}