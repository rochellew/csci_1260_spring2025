using System.ComponentModel.DataAnnotations;

namespace IntroToBlazor.Models
{
    public class Villager
    {
        [Required(ErrorMessage = "Villager Name is required!")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = "Villager hobby is required!")]
        public string Hobby { get; set; } = string.Empty;
    }
}
