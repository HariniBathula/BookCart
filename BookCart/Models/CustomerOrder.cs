using System;
using System.Collections.Generic;

namespace BookCart.Models;

public partial class CustomerOrder
{
    public string OrderId { get; set; } = null!;

    public int UserId { get; set; }

    public DateTime DateCreated { get; set; }

    public decimal CartTotal { get; set; }
}
