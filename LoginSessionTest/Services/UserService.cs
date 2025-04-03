using LoginSessionTest.Data;
using LoginSessionTest.Interfaces;
using LoginSessionTest.Models; 

namespace LoginSessionTest.Services
{
    public class UserService : IUserService
    {
        public void AddUser(User newUser)
        {
            MockData.UserData.Add(newUser);
        }

        public List<User> GetAllUsers()
        {
            return MockData.UserData;
        }

        public User GetUserByUserName(string userName)
        {
            return MockData.UserData.Find( u => u.UserName == userName);
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
