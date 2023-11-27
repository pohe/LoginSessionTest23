using LoginSessionTest.Interfaces;
using LoginSessionTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginSessionTest.Pages.Users
{
    public class LoginModel : PageModel
    {
        [BindProperty] public string UserName { get; set; }
        [BindProperty] public string PassWord { get; set; }

        public string Message { get; set; }

        private IUserService _userService;
        public LoginModel(IUserService userservice)
        {
            _userService = userservice;
        }

        public void OnGet()
        {
        }

        public void OnGetLogout()
        {
            HttpContext.Session.Remove("UserName");
        }

        public IActionResult OnPost()
        {
            User loginUser = _userService.VerifyUser(UserName, PassWord);
            if (loginUser != null)
            {
               
                HttpContext.Session.SetString("UserName", loginUser.UserName);
                return RedirectToPage("/Welcome");
            }
            else
            {
                Message = "Invalid username or password";
                UserName = "";
                PassWord = "";
                return Page();
            }

        }
    }
}
