using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="*Introduceți adresa de Email!")]
        public string EmailAdress { get; set; }

        [Required(ErrorMessage = "*Introduceți Username-ul!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*Introduceți parola!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}