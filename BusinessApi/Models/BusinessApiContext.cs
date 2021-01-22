using Microsoft.EntityFrameworkCore;

namespace BusinessApi.Models
{
  public class BusinessApiContext : DbContext
  {
    public BusinessApiContext(DbContextOptions<BusinessApiContext> options) : base(options) { }

    public virtual DbSet<Restaurant> Restaurants { get; set; }
    public virtual DbSet<Shop> Shops { get; set; }
  }
}