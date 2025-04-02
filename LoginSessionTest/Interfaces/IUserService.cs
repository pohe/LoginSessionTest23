using LoginSessionTest.Models;

namespace LoginSessionTest.Interfaces
{
    public interface IUserService
    {
        void AddUser(User newUser);
        public List<User> GetAllUsers();
       
        public User VerifyUser(string userName, string passWord);
    }
}
