using LoginSessionTest.Data;
using LoginSessionTest.Interfaces;
using LoginSessionTest.Models; 

namespace LoginSessionTest.Services
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            return MockData.UserData;
        }

 
        public User VerifyUser(string userName, string passWord) {
            foreach (var user in GetAllUsers())
            {
                if (userName.Equals(user.UserName) && passWord.Equals(user.Password))
                {
                    return user;
                }
            }
            return null;

        }
    }
}
