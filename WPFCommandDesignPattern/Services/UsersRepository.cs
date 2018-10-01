using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityDataAccess;

namespace WPFCommandDesignPattern.Services
{
    public class UsersRepository : IUsersRepository
    {
        SecurityDataAccessContext _context = new SecurityDataAccessContext();

        public Task<SecurityDataAccess.Users> AddUserAsync(SecurityDataAccess.Users user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<SecurityDataAccess.Users> GetUserAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SecurityDataAccess.Users>> GetUsersAsync()
        {
            return _context.Users.ToListAsync();
        }

        public Task<SecurityDataAccess.Users> UpdateUserAsync(SecurityDataAccess.Users user)
        {
            throw new NotImplementedException();
        }
    }
}
