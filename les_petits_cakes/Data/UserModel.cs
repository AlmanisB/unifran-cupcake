namespace les_petits_cakes.Data;

public class UserModel(string name, string email, string password, string roles, int id)
{
  public string Name { get; set; } = name;
  public string Email { get; set; } = email;
  public string Password { get; set; } = password;
  public string Roles { get; set; } = roles;
  public int Id { get; set; } = id;
  public List<UserAddressModel>? UserAddresses { get; set; }
}