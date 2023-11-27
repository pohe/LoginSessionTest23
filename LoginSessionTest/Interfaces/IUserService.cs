using LoginSessionTest.Models;

namespace LoginSessionTest.Interfaces
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
       
        public User VerifyUser(string userName, string passWord);
    }
}
