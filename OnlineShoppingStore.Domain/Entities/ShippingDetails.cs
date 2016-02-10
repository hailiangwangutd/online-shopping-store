using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter an address")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a zip code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
