using MinimalAPI.Infrastructure.Interfaces;
using MinimalAPI.Domain.DTO;
using MinimalAPI.Domain.Entities;
using MinimalAPI.Infrastructure.Db;

namespace MinimalAPI.Domain.Services
{
  public class AdministratorServices(MinimalApiDbContext minimalApiDbContext) : IAdministratorServices
  {

    private readonly MinimalApiDbContext _minimalApiDbContext = minimalApiDbContext;

    public Administrator? Login(LoginDTO loginDTO)
    {

      return _minimalApiDbContext.Administrators.Where(x => x.Email == loginDTO.Email && x.Password == loginDTO.Password).FirstOrDefault();

    }

  }
}