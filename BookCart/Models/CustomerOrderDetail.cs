using System;
using System.Collections.Generic;

namespace BookCart.Models;

public partial class CustomerOrderDetail
{
    public int OrderDetailsId { get; set; }

    public string OrderId { get; set; } = null!;

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
