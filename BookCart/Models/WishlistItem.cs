using System;
using System.Collections.Generic;

namespace BookCart.Models;

public partial class WishlistItem
{
    public int WishlistItemId { get; set; }

    public string WishlistId { get; set; } = null!;

    public int ProductId { get; set; }
}
