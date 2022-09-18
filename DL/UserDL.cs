using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DL
{
    public class UserDL : IUserDL
    {
        salseContext _salseContext;

        public UserDL(salseContext salseContext)
        {
            _salseContext = salseContext;
        }
        public async Task<User> GetDL(string email, string password)
        {
            var useToGet = await _salseContext.Users.Where(u =>
              u.EmailUser == email && u.PasswordUser == password)
             .FirstOrDefaultAsync();
            if (useToGet == null)
                { return null; }
            return useToGet;
        }

        public async Task<User> PostDL(User user)
        {

            await _salseContext.Users.AddAsync(user);
            await _salseContext.SaveChangesAsync();
            return user;
       
        }

        public async Task<User> PutDL(int id, User userToUpdate)
        {
            var userToupdate2 = await _salseContext.Users.FindAsync(id);
            if (userToupdate2 == null)
            {
                return null;
            }
            userToUpdate.UserId = userToupdate2.UserId;
            _salseContext.Entry(userToupdate2).CurrentValues.SetValues(userToUpdate);
            await _salseContext.SaveChangesAsync();
            return userToUpdate;
        }
    }
}
            
        
    
