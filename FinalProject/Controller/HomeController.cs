using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCoreApplication.Models;

namespace FinalProject.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly ReviewsDbContext _context;
        public HomeController(ReviewsDbContext context)
        {
            _context = context;
        }

/*        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.ToListAsync());
        }*/

    }
}