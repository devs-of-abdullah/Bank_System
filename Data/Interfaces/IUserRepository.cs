using Entities.DTOs;

namespace Data.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDto?> GetByEmail(string email);
        Task<UserDto?> GetById(int id);

        Task<bool> IsExistsById(int id);
        Task<bool> IsExistsByEmail(string email);
        Task Add (RegisterUserDto user);
    }
}
