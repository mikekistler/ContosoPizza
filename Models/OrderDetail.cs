namespace ContosoPizza.Models;

// Represents the many-to-many relationship between Order and Product
// Teddy Smith's convention would name this class OrderProduct
public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;
}