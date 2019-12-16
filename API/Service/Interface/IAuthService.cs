using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service.Interface
{
    public interface IAuthService
    {
        Task<UserAccount> Login(string username, string password);
        Task<UserAccount> Register(UserAccount user, string password);
        Task<UserAccount> FindByNameAsync(string username);
        Task<UserAccount> GetById(int Id);
        Task<Role> GetRolesAsync(int role);
        Task<List<Menu>> GetMenusAsync(int role);

        Task<UserAccount> Edit(string username);
    }
}
