using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication051024_Fitnes.Data;
using WebApplication051024_Fitnes.Models;

namespace WebApplication051024_Fitnes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticData.Categories);
        }

        public IActionResult Category(int id)
        {
            var category = StaticData.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();

            return View(category);
        }

        public IActionResult Article(int id)
        {
            var article = StaticData.Categories.SelectMany(c => c.Articles).FirstOrDefault(a => a.Id == id);
            if (article == null) return NotFound();

            return View(article);
        }
    }
}
