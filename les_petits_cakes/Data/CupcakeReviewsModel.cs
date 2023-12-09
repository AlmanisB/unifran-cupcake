namespace les_petits_cakes.Data;

public class CupcakeReviewsModel(int id, int userId, int cupcakeId, int rating)
{
  public int Id { get; set; } = id;
  public int UserId { get; set; } = userId;
  public UserModel? User { get; set; }
  public int CupcakeId { get; set; } = cupcakeId;
  public CupcakeModel? Cupcake { get; set; }
  public int Rating { get; set; } = rating;
}