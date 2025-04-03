using LoginSessionTest.Interfaces;
using LoginSessionTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginSessionTest.Pages.Users
{
    public class GetAllUsersModel : PageModel
    {
        private IUserService _userService;

        public string UserName { get; set; }
        public List<User> Users { get; set; }
        public GetAllUsersModel(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            if (UserName == null)
            {
                return RedirectToPage("/Users/Login");
            }
            Users = _userService.GetAllUsers();
            return Page();
        }
    }
}
