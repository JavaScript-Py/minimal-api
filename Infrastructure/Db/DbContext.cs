using Microsoft.EntityFrameworkCore;

namespace MinimalAPI.Infrastructure.Db;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
  public DbContext(DbContextOptions<DbContext> options) : base(options)
  {
  }
}
