namespace les_petits_cakes.Data;

public class OrderItemModel(int id, int quantity, decimal price, decimal discount, int orderId, int couponId, int cupcakeId)
{
  public int Id { get; set; } = id;
  public int Quantity { get; set; } = quantity;
  public decimal Price { get; set; } = price;
  public decimal Discount { get; set; } = discount;
  public decimal TotalPrice => Math.Round((Quantity * Price) - (Discount * Price), 2);
  public int OrderId { get; set; } = orderId;
  public OrderModel? Order { get; set; }
  public int CouponId { get; set; } = couponId;
  public CouponModel? Coupon { get; set; }
  public int CupcakeId { get; set; } = cupcakeId;
  public CupcakeModel? Cupcake { get; set; }
}