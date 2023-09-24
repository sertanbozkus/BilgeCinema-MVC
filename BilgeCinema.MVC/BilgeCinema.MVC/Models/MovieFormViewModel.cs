using System.ComponentModel.DataAnnotations;

namespace BilgeCinema.MVC.Models
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Filmin Adı")]
        public string Name { get; set; }

        [Display(Name = "Filmin Türü")]
        public string Type { get; set; }

        [Display(Name = "Filmin Yönetmeni")]
        public string Director { get; set; }

        [Display(Name = "Bilet Fiyatı")]
        public decimal UnitPrice { get; set; }

    }
}
