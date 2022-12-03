using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Pages
{
    public class Ben : PageModel
    {
        private readonly ILogger<Ben> _logger;

        public Ben(ILogger<Ben> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
