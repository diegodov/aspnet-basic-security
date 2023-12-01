using BasicSecurityASP.Models;

namespace BasicSecurityASP.Services
{
    public class UserService : IUserService
    {

        List<User> users = new List<User>()
        {
            new User() {Email = "pato@hotmail.com", Password = "123456"},
            new User() {Email = "pato2@hotail.com", Password = "123456"}
        }; 

        public bool Login(string email, string password) =>  
          users.Where(d => d.Email == email && d.Password == password).Count() > 0;
    }
}