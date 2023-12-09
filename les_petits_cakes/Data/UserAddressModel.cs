namespace les_petits_cakes.Data;

public class UserAddressModel(int id, string addressLine1, string addressLine2, string city, string state, string postalCode, int userId)
{
  public int Id { get; set; } = id;
  public string AddressLine1 { get; set; } = addressLine1;
  public string AddressLine2 { get; set; } = addressLine2;
  public string City { get; set; } = city;
  public string State { get; set; } = state;
  public string PostalCode { get; set; } = postalCode;
  public int UserId { get; set; } = userId;
  public UserModel? User { get; set; }
}