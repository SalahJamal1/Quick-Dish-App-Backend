﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApplication.Data;

public class Cart
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    [ForeignKey(nameof(ItemId))]
    public int ItemId { get; set; }
    public Item Item { get; set; }
}