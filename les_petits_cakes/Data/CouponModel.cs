namespace les_petits_cakes.Data;

public class CouponModel(int id, string code, decimal discount, bool isPercent, bool isMultipleUse, bool isUnlimited, int maxUses, DateTime expirationDate, bool isActive, bool isDeleted)
{
  public int Id { get; set; } = id;
  public string Code { get; set; } = code;
  public decimal Discount { get; set; } = discount;
  public bool IsPercent { get; set; } = isPercent;
  public bool IsMultipleUse { get; set; } = isMultipleUse;
  public bool IsUnlimited { get; set; } = isUnlimited;
  public int MaxUses { get; set; } = maxUses;
  public DateTime ExpirationDate { get; set; } = expirationDate;
  public bool IsActive { get; set; } = isActive;
  public bool IsDeleted { get; set; } = isDeleted;
}