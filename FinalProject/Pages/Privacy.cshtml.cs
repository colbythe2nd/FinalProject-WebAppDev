﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Pages
{
    public class Privacy : PageModel
    {
        private readonly ILogger<Privacy> _logger;

        public Privacy(ILogger<Privacy> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
