using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BL
{
    public interface IUserBL
    {
        Task<User> GetBL(string email, string password);
        Task<User> PostBL(User user);
        Task<User> PutBL(int id, User user);
    }
}
