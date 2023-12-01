namespace BasicSecurityASP.Services
{
    public interface IUserService
    {
        public bool Login(string email, string password);
    }
}
