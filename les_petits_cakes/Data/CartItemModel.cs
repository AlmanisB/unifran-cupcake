namespace les_petits_cakes.Data;

public class CartItemModel
{
  public int Quantity { get; set; }
  public required CupcakeModel CupcakeModel { get; set; }
  public decimal TotalPrice => Math.Round(Quantity * (CupcakeModel.Price - CupcakeModel.Discount), 2);
}