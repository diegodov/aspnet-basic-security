using BasicSecurityASP.Models;

namespace BasicSecurityASP.Services
{
    public class UserService : IUserService
    {

        List<User> users = new List<User>()
        {
            new User() {Email = "admin", Password = "admin"},
            new User() {Email = "user", Password = "user"}
        }; 

        public bool Login(string email, string password)
        {   
            users.Where(d => d.Email == email && d.Password == password).FirstOrDefault();
            throw new NotImplementedException();
        }
    }
}
