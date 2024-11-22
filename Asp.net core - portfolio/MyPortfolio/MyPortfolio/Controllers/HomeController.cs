using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio
            {
                Id = 1, category = "python", title = "shop project", date = "may 13, 2023", image = "article3.png"
            },
            new Portfolio
            {
                Id = 1, category = "python", title = "reservation project", date = "june 28, 2024", image = "article3.png"
            },
            new Portfolio
            {
                Id = 1, category = "c#", title = "portfolio project", date = "november 22, 2024", image = "article3.png"
            },
            new Portfolio
            {
                Id = 1, category = "c#", title = "calculator project", date = "november 22, 2024", image = "article3.png"
            },

        };
        public IActionResult Index()
        {
            ViewData["headingtitle"] = "Im just a normal programmer";
            ViewData["headdescription"] =
                "and my name is alireza ,im a python and c# developer Nice to Meet you";

            var contact = new Contact()
            {
                location = "ahwaz",
                email = "alireza.rezaeifard13811@gmail.com",
                phone = 9391734449
            };

            var model = new CombinedViewModel
            {
                Contact = contact,
                Portfolios = _portfolios // Corrected to pass the list of portfolios
            };
            return View(model);
        }

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                location = "ahwaz",
                email = "alireza.rezaeifard13811@gmail.com",
                phone = 9391734449
            };

            return View(contact);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}