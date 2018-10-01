using SecurityDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCommandDesignPattern.Services
{
    interface IUsersRepository
    {
        Task<List<SecurityDataAccess.Users>> GetUsersAsync();
        Task<SecurityDataAccess.Users> GetUserAsync(Int64 id);
        Task<SecurityDataAccess.Users> AddUserAsync(SecurityDataAccess.Users user);
        Task<SecurityDataAccess.Users> UpdateUserAsync(SecurityDataAccess.Users user);
        Task DeleteUserAsync(Guid userId);
    }
}
