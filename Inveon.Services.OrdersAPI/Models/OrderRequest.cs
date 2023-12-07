using System;

public class OrderRequest
{
    public string UserId { get; set; }
    public List<CartItem> CartItems { get; set; }
}
