using WebAppApiRest.Core.Models;

namespace WebAppApiRest.Users.Data
{
    public interface IUserRepository
    {
        Task<List<User>> ListAll();
        Task<User?> Find(int id);
        Task<bool> Create(User user);
        Task<bool> Update(User user);
        Task<bool> Delete(User user);
    }
}
