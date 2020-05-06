using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class UserRegisterModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Introduceți Numele!")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Introduceți Prenumele!")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Introduceți adresa de Email!")]
        [Display(Name = "EmailAdress")]
        public string EmailAdress { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Introduceți Username-ul!")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Introduceți Parola!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirmați Parola!")]
        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirmata parola!")]
        public string ConfirmPassword { get; set; }

        public string SuccessMessage { get; set; }
    }
}