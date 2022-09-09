using System.ComponentModel.DataAnnotations;

namespace GlobalGamesGS.Data.Entities
{
    public class BudgetForm : IEntity
    {
        public int Id { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
