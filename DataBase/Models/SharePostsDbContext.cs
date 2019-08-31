using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SharePosts.DataBase.Models
{
  public class SharePostsDbContext : IdentityDbContext
  {
    public SharePostsDbContext(DbContextOptions<SharePostsDbContext> options) : base (options) { }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
  }
}
