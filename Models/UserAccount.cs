using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BTVBookRental.Models
{
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Va rugam introduceti un prenume")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Va rugam introduceti un nume")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Va rugam introduceti o adresa de e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Va rugam introduceti un nume de utilizator")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Va rugam introduceti o parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
        [Compare("Password", ErrorMessage = "Parolele nu se potrivesc")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
