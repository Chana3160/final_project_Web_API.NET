using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DL
{
    //public class DLClass
    //{
    //    public User GetUser(string Email, string Password)
    //    {
    //        using (StreamReader reader = System.IO.File.OpenText("M:/API/MyProjectWebAPI/MyProjectWebAPI/filepath.txt"))
    //        {
    //            string currentUser;
    //            while ((currentUser = reader.ReadLine()) != null)
    //            {
    //                User user = JsonSerializer.Deserialize<User>(currentUser);
    //                if (user.EmailUser.Equals(Email) && user.PasswordUser.Equals(Password))
    //                    return user;
    //            }
    //        }
    //        return null;
    //    }
    //    public User PostUser(User user)
    //    {
    //        int numberOfUsers = System.IO.File.ReadLines("M:/API/MyProjectWebAPI/MyProjectWebAPI/filepath.txt").Count();
    //        //  user. = numberOfUsers + 1;
    //        string userJson = JsonSerializer.Serialize(user);
    //        System.IO.File.AppendAllText("M:/API/MyProjectWebAPI/MyProjectWebAPI/filepath.txt", userJson + Environment.NewLine);
    //        return user;
    //    }
    //    public void PutUser(int id, User newUser)
    //    {
    //        string textToReplace = "";
    //        using (StreamReader reader = System.IO.File.OpenText("M:/API/MyProjectWebAPI/MyProjectWebAPI/filepath.txt"))
    //        {
    //            string currentUser;
    //            while ((currentUser = reader.ReadLine()) != null)
    //            {

    //                User user = JsonSerializer.Deserialize<User>(currentUser);
    //                if (user.UserId == id)
    //                    textToReplace = currentUser;
    //            }
    //        }

    //        if (textToReplace != string.Empty)
    //        {
    //            string text = System.IO.File.ReadAllText("M:/API/MyProjectWebAPI/MyProjectWebAPI/filepath.txt");
    //            text = text.Replace(textToReplace, JsonSerializer.Serialize(newUser));
    //            System.IO.File.WriteAllText("M:/API/MyProjectWebAPI/MyProjectWebAPI/filepath.txt", text);
    //        }
    //    }
    //}
}
