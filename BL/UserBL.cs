using DL;
using Entity;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL:IUserBL
    {
        IUserDL _userDL;
       
        public UserBL(IUserDL userDL)
        {
            _userDL = userDL;
        }
        public async Task<User> GetBL(string email, string password)
        {
            return await _userDL.GetDL(email, password);
        }
        public async Task<User> PostBL(User user)
        {
            return await _userDL.PostDL(user);
        
        }
        public async Task<User> PutBL(int id, User user)
        {
          return await _userDL.PutDL(id, user);
        }

    }
}
