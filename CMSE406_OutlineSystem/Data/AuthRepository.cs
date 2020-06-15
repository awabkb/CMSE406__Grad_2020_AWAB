using CMSE406_OutlineSystem.Models;
using CMSE406_OutlineSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSE406_OutlineSystem.Data
{
    
        public class AuthRepository : IAuthRepository
        {
            private readonly DataContext _context;
            public AuthRepository(DataContext context)
            {
                _context = context;
            }
            public async Task<User> Login(string userId, string password)
            {
                 var user = await _context.Users.FirstOrDefaultAsync(x => x.Id.Equals(Int16.Parse(userId)));

                if (user == null)
                {
                    return null;
                }
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            return user;
            }

            private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
            {
                using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
                {
                    var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                    for (int i = 0; i < computedHash.Length; i++)
                    {
                        if (computedHash[i] != passwordHash[i]) return false;
                    }
                }

                return true;
            }


            private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }

      
    }
    
}
