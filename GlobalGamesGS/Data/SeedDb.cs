using GlobalGamesGS.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesGS.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        


        public SeedDb(DataContext context, IBudgetFormRepository budgetForm, INewsletterRepository newsletter)
        {
            _context = context;
           
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();


            if (!_context.Newsletter.Any())
            {
                var news = new Newsletter
                {
                    Email = "nada@nepia.nd",
                };
                _context.Newsletter.Add(news);

            }




            if (!_context.BudgetForm.Any())
            {
                var budget = new BudgetForm
                {
                    Name = "nada",
                    Email = "nada@nepia.nd",
                    Message = "nada vazio nenhum"
                };
                _context.BudgetForm.Add(budget);

            }




        }

    }
}
