using GlobalGamesGS.Data.Entities;
using GlobalGamesGS.Helperes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesGS.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;


        public SeedDb(DataContext context, IBudgetFormRepository budgetForm, INewsletterRepository newsletter, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();



            var user = await _userHelper.GetUserByEmailAsync("dalton.fury120@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Gonçalo",
                    LastName = "Silva",
                    Email = "dalton.fury120@gmail.com",
                    UserName = "dalton.fury120@gmail.com",
                    PhoneNumber = "123456789"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }






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
