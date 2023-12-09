using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace les_petits_cakes.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
  public DbSet<CupcakeModel> Cupcakes { get; set; }
  public DbSet<CupcakeReviewsModel> CupcakeReviews { get; set; }
  public DbSet<OrderModel> Orders { get; set; }
  public DbSet<OrderItemModel> OrderItems { get; set; }
  public DbSet<UserModel> Users { get; set; }
  public DbSet<CouponModel> Coupons { get; set; }
}