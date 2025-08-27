using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrochetCraft.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Homepage logic can be added here
            _logger.LogInformation("Homepage accessed");
        }
    }
}
