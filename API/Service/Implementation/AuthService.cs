using API.Data;
using API.Models;
using API.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service.Implementation
{
    public class AuthService: IAuthService
    {
        private readonly DataContext _context;
        public AuthService(DataContext context)
        {
            _context = context;
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }
        public async Task<UserAccount> Login(string username, string password)
        {
            var user = await _context.UserAccounts.FirstOrDefaultAsync(x => x.Username == username);

            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            return user;
        }
        public async Task<Role> GetRolesAsync(int role)
        {
            return await _context.Roles.FirstOrDefaultAsync(x => x.ID == role);
        }
        public async Task<UserAccount> FindByNameAsync(string username)
        {
            var item = await _context.UserAccounts.FirstOrDefaultAsync(x => x.Username == username);
            if (item != null)
                return item;

            return null;
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        public async Task<UserAccount> Register(UserAccount user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.UserAccounts.AddAsync(user);

            await _context.SaveChangesAsync();

            return user;
        }
        public async Task<UserAccount> Edit(string username)
        {
            var item = await _context.UserAccounts.FirstOrDefaultAsync(x => x.Username == username);
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash("1", out passwordHash, out passwordSalt);
            item.PasswordHash = passwordHash;
            item.PasswordSalt = passwordSalt;

            await _context.SaveChangesAsync();

            return item;
        }
        public async Task<UserAccount> GetById(int Id)
        {
            return await _context.UserAccounts.FirstOrDefaultAsync(x => x.ID == Id);
        }
        public async Task<List<Menu>> GetMenusAsync(int role)
        {
            return await _context.Menus.Where(x => x.RoleID == role).ToListAsync();
        }
    }
}
