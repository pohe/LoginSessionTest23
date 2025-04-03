using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginSessionTest.Pages.Users
{
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;

        [BindProperty]
        public User NewUser { get; set; }

        public CreateUserModel(IUserService userService)
        {
            _userService = userService;
        }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {

            //NB bør checke om der er en user allerede med samme username!
            _userService.AddUser(NewUser);
            return Page();
        }
    }
}
