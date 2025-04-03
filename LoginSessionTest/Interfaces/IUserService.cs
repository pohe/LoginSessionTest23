using LoginSessionTest.Models;

namespace LoginSessionTest.Interfaces
{
    public interface IUserService
    {
        void AddUser(User newUser);
        List<User> GetAllUsers();
        User GetUserByUserName(string userName);
        User VerifyUser(string userName, string passWord);
    }
}
