using AuthApi.Models;

namespace AuthApi.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
