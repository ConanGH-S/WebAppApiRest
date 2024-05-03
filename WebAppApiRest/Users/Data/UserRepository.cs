using Microsoft.EntityFrameworkCore;
using WebAppApiRest.Core.Data;
using WebAppApiRest.Core.Models;

namespace WebAppApiRest.Users.Data
{
    public class UserRepository(ApiDbContext context): IUserRepository
    {
        private readonly ApiDbContext _context = context;

        public async Task<List<User>> ListAll()
        {
            return await _context.Users.Where(u => u.IsActive).ToListAsync();
        }

        public async Task<User?> Find(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<bool> Create(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(User user)
        {
            user.IsActive = false;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
