using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginSessionTest.Pages
{
    public class WelcomeModel : PageModel
    {
        public string UserName { get; set; }
        public IActionResult OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            if (UserName== null)
            {
                return RedirectToPage("Users/Login");
            }
            else
                return Page();
        }
    }
}
