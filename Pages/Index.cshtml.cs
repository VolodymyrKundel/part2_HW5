using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace part2_HW5.Pages
{
    public class AboutMeModel : PageModel
    {
        private readonly ILogger<AboutMeModel> _logger;

        public AboutMeModel(ILogger<AboutMeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}