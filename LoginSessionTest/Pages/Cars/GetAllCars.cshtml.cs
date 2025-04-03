using LoginSessionTest.Interfaces;
using LoginSessionTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginSessionTest.Pages.Cars
{
    public class GetAllCarsModel : PageModel
    {
        private ICarService _carService;
        private IUserService _userService;

        public string UserName { get; set; }

        public List<Car> Cars { get; set; }

        public GetAllCarsModel(ICarService carService, IUserService userservice)
        {
            _carService = carService;
            _userService = userservice;
        }

        public IActionResult OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            if (UserName == null)
            {
                return RedirectToPage("/Users/Login");
            }
            Cars = _carService.GetAllCars();
            return Page();
        }

        public IActionResult OnPostAddDriver(string carRegNr)
        {
            UserName = HttpContext.Session.GetString("UserName");
            if (UserName == null)
            {
                return RedirectToPage("/Users/Login");
            }
            User currentUser = _userService.GetUserByUserName(UserName);

            Car aCar = _carService.GetCarByRegnr(carRegNr);
            aCar.AddDriver(currentUser);
            return Page();
        }
    }
}
