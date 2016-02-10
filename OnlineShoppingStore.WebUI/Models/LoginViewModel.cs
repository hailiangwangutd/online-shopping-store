using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please input username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please input password")]
        public string PassWord { get; set; }
    }
}