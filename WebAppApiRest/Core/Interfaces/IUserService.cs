using WebAppApiRest.Core.Models;

namespace WebAppApiRest.Core.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> ListUsers();
        Task<User?> FindUser(int? id);
        Task<bool> CreateUser(User? user);
        Task<bool> UpdateUser(int? id, User user);
        Task<bool> DeleteUser(int? id);
    }
}
