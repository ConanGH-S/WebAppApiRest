using WebAppApiRest.Core.Interfaces;
using WebAppApiRest.Core.Models;
using WebAppApiRest.Users.Data;

namespace WebAppApiRest.Core.Services
{
    public class UserService(IUserRepository repository): IUserService
    {
        private readonly IUserRepository _userRepository = repository;

        public async Task<List<User>> ListUsers()
        {
            return await _userRepository.ListAll();
        }

        public async Task<User?> FindUser(int? id)
        {
            ArgumentNullException.ThrowIfNull(id);
            int userId = id.Value;
            return await _userRepository.Find(userId);
        }

        public async Task<bool> CreateUser(User? user)
        {
            ArgumentNullException.ThrowIfNull(user);
            return await _userRepository.Create(user);
        }

        public async Task<bool> UpdateUser(int? id, User user)
        {
            ArgumentNullException.ThrowIfNull(id);
            int userId = id.Value;
            var userExist = await FindUser(userId);
            ArgumentNullException.ThrowIfNull(userExist);
            return await _userRepository.Update(user);
        }

        public async Task<bool> DeleteUser(int? id)
        {
            ArgumentNullException.ThrowIfNull(id);
            int userId = id.Value;
            var user = await FindUser(userId);
            ArgumentNullException.ThrowIfNull(user);
            return await _userRepository.Delete(user);
        }
    }
}
