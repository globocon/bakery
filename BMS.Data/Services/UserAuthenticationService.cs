using BMS.Data.Helpers;
using BMS.Data.Models;


namespace BMS.Data.Services
{
    public interface IUserAuthenticationService
    {
        bool TryGetLoginUser(USR_Login userLogin, out USR_Users user);
    }
    public class UserAuthenticationService : IUserAuthenticationService
    {
        private readonly BMSDbContext _context;
        public UserAuthenticationService(BMSDbContext context)
        {
            _context = context;
        }
        public bool TryGetLoginUser(USR_Login userLogin, out USR_Users user)
        {
            user = null;

            if (userLogin != null &&
                !string.IsNullOrEmpty(userLogin.LoginId) &&
                !string.IsNullOrEmpty(userLogin.Password))
            {
                user = _context.USR_Users.FirstOrDefault(u => u.LoginId == userLogin.LoginId && u.IsDeleted == false);
                if (user != null && PasswordHelper.VerifyEncryptedPassword(user.Password, userLogin.Password))
                    return true;
            }

            return false;
        }
    }
}
