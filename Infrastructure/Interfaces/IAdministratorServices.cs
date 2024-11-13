using MinimalAPI.Domain.Entities;

using MinimalAPI.Domain.DTO;

namespace MinimalAPI.Infrastructure.Interfaces
{
  public interface IAdministratorServices
  {
    Administrator? Login(LoginDTO loginDTO);

  }
}