using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MinimalAPI.Domain.Entities;
namespace MinimalAPI.Infrastructure.Db;

public class MinimalApiDbContext(DbContextOptions options) : Microsoft.EntityFrameworkCore.DbContext(options)
{
  public DbSet<Administrator> Administrators { get; set; } = default!;

  public DbSet<Vehicle> Vehicles { get; set; } = default!;

}