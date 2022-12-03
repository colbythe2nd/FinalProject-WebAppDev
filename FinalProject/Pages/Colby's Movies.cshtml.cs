using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Pages
{
    public class Colby : PageModel
    {
        private readonly ILogger<Colby> _logger;

        public Colby(ILogger<Colby> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
