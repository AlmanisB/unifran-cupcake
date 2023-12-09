using Microsoft.AspNetCore.Components;

namespace les_petits_cakes.Data;

public class CupcakeModel(string title, string description, string image, decimal price, decimal discount, string category, int heat, int id, int stock)
{
  public string Title { get; set; } = title;
  public string Description { get; set; } = description;
  public string Image { get; set; } = image;
  public decimal Price { get; set; } = price;
  public decimal Discount { get; set; } = discount;
  public string Category { get; set; } = category;
  public int Heat { get; set; } = heat;
  public int Stock { get; set; } = stock;
  public int Id { get; set; } = id;
}