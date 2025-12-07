using System;
using System.Collections.Generic;

namespace BookCart.Models;

public partial class CartItem
{
    public int CartItemId { get; set; }

    public string CartId { get; set; } = null!;

    public int ProductId { get; set; }

    public int Quantity { get; set; }
}
