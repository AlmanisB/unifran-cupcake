using les_petits_cakes.Data;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace les_petits_cakes.Services;

public class ShoppingCartService(ProtectedLocalStorage protectedLocalStorage, ApplicationDbContext applicationDbContext)
{
  private const string CartKey = "shoppingCart";

  public event Action? OnChange;

  public async Task AddToCart(CupcakeModel cupcakeModel)
  {
    var cartItems = await GetCartItems();

    var existingItem = cartItems.Find(item => item.CupcakeModel.Id == cupcakeModel.Id);
    if (existingItem != null)
    {
      existingItem.Quantity += 1;
    }
    else
    {
      var newItem = new CartItemModel { CupcakeModel = cupcakeModel, Quantity = 1 };
      cartItems.Add(newItem);
    }

    await SaveCart(cartItems);
  }

  public async Task<int> GetCartCount()
  {
    var cartItems = await GetCartItems();
    return cartItems.Sum(item => item.Quantity);
  }

  public async Task<List<CartItemModel>> GetCartItems()
  {
    var result = await protectedLocalStorage.GetAsync<List<CartItemModel>>(CartKey);

    if (!result.Success || result.Value == null) return new List<CartItemModel>();

    return (from cartItem in result.Value
      join cupcake in applicationDbContext.Cupcakes on cartItem.CupcakeModel.Id equals cupcake.Id
      where cupcake.Stock > 0
      select new CartItemModel { CupcakeModel = cupcake, Quantity = Math.Min(cartItem.Quantity, cupcake.Stock) }).ToList();
  }

  public async Task ClearCart()
  {
    await protectedLocalStorage.DeleteAsync(CartKey);
    OnChange?.Invoke();
  }

  public async Task DecrementQuantity(CartItemModel cartItemModel)
  {
    var cartItems = await GetCartItems();

    var existingItem = cartItems.Find(item => item.CupcakeModel.Id == cartItemModel.CupcakeModel.Id);
    if (existingItem != null)
    {
      existingItem.Quantity -= 1;
      if (existingItem.Quantity == 0)
      {
        cartItems.Remove(existingItem);
      }
    }

    await SaveCart(cartItems);
  }

  public async Task IncrementQuantity(CartItemModel cartItemModel)
  {
    var cartItems = await GetCartItems();

    var existingItem = cartItems.Find(item => item.CupcakeModel.Id == cartItemModel.CupcakeModel.Id);
    if (existingItem != null)
    {
      existingItem.Quantity += 1;
    }

    await SaveCart(cartItems);
  }

  private async Task SaveCart(List<CartItemModel> cartItems)
  {
    await protectedLocalStorage.SetAsync(CartKey, cartItems);
    OnChange?.Invoke();
  }
}