using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CrochetCraft.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        [Required]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        public string Message { get; set; }

        public bool MessageSent { get; set; }

        public void OnGet()
        {
            MessageSent = false;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Handle the message sending logic, e.g., save to db or send email
            MessageSent = true;

            ModelState.Clear();
            return Page();
        }
    }
}