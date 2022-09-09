using System.ComponentModel.DataAnnotations;

namespace GlobalGamesGS.Data.Entities
{
    public class Newsletter : IEntity
    {
        public int Id { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
