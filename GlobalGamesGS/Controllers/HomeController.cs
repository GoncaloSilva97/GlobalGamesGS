using GlobalGamesGS.Data;
using GlobalGamesGS.Data.Entities;

using GlobalGamesGS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesGS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


       
        private readonly INewsletterRepository _newsletterRepository;
        private readonly IBudgetFormRepository _budgetFormRepository;



        public HomeController(
            ILogger<HomeController> logger,
            IBudgetFormRepository budgetFormRepository,
            INewsletterRepository newsletterRepository)
        {
            _logger = logger;
            _newsletterRepository = newsletterRepository;
            _budgetFormRepository = budgetFormRepository;

        }



        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(Newsletter newsletter)
        {
            if (newsletter != null)
            {
                
                await _newsletterRepository.CreateAsync(newsletter);

            }

            return RedirectToAction(nameof(Home));

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitBudgetForm(BudgetForm budgetForm)
        {
            if (budgetForm != null)
            {

                await _budgetFormRepository.CreateAsync(budgetForm);

            }

            return RedirectToAction(nameof(Home));

        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
