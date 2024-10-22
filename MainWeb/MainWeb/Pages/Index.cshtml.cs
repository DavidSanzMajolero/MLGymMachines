using MainWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace MainWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly GymMachineService _context;



        public IndexModel(ILogger<IndexModel> logger, GymMachineService service)
        {
            _logger = logger;
            _context = service;
        }

        public void OnGet()
        {
            
        }
    }
}
