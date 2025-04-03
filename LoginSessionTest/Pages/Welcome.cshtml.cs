using LoginSessionTest.Interfaces;
using LoginSessionTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginSessionTest.Pages
{
    public class WelcomeModel : PageModel
    {
        private IUserService _userService; 
        public string UserName { get; set; }

        public User CurrentUser { get; set; }

        public WelcomeModel(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            if (UserName== null)
            {
                return RedirectToPage("Users/Login");
            }
            else
            {
                CurrentUser = _userService.GetUserByUserName(UserName); 
            }
            return Page();
        }
    }
}
