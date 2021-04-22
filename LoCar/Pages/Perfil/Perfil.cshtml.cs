using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoCar.Pages
{
    public class PerfilModel : PageModel
    {
        private readonly ILogger<PerfilModel> _logger;

        public PerfilModel(ILogger<PerfilModel> logger)
        {
           _logger = logger;
        }
 
        public void OnGet()
        {
        }
    }
}
