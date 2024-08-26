using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dz_dz_dz.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                Response.Redirect("/Welcome");
            }
        }

        public IActionResult OnPost()
        {
            if (Username == "administrator" && Password == "qwerty")
            {
                HttpContext.Session.SetString("Username", Username);
                return RedirectToPage("/Welcome");
            }
            else
            {
                ErrorMessage = "Login or password is incorrect";
                return Page();
            }
        }
    }
}
