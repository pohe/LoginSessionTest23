﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginSessionTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string UserName { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            UserName = HttpContext.Session.GetString("UserName");
            if (UserName == null)
            {
                return RedirectToPage("Users/Login");
            }
            else
                return Page();

        }
    }
}