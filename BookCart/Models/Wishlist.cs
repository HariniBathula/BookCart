using System;
using System.Collections.Generic;

namespace BookCart.Models;

public partial class Wishlist
{
    public string WishlistId { get; set; } = null!;

    public int UserId { get; set; }

    public DateTime DateCreated { get; set; }
}
