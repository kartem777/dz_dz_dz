using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dz_dz_dz.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Username { get; set; }

        public void OnGet()
        {
            Username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(Username))
            {
                Response.Redirect("/Login");
            }
        }

        public IActionResult OnPost()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToPage("/Login");
        }
    }
}
