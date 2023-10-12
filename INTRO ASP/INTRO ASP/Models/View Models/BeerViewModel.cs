using System.ComponentModel.DataAnnotations;

namespace INTRO_ASP.Models.View_Models
{
    public class BeerViewModel
    {
        [Display(Name ="Nombre")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Display(Name ="Marca")]
        public int BrandId { get; set; }
    }
}
