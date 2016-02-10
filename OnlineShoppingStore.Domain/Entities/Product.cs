using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "required area")]
        public string Name { get; set; }
        [Required(ErrorMessage = "required area")]
        public string Description { get; set; }
        [Required(ErrorMessage = "required area")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "required area")]
        public string Category { get; set; }
    }
}
