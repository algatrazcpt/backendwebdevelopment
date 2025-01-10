using Microsoft.AspNetCore.Identity;

namespace Pratik1Identity.Models
{
    public class Users: IdentityUser
    {
        string userName;
        string  password;

        public Users(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

    }
}
