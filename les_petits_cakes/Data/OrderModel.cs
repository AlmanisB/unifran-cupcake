namespace les_petits_cakes.Data;

public class OrderModel(int id, int userId, decimal totalPrice, string status, DateTime createdAt, DateTime updatedAt)
{
  public int Id { get; set; } = id;
  public int UserId { get; set; } = userId;
  public UserModel? User { get; set; }
  public decimal TotalPrice { get; set; } = totalPrice;
  public string Status { get; set; } = status;
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;
  public List<OrderItemModel>? OrderItems { get; set; }
}