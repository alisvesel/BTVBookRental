using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTVBookRental.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }

        [Display(Name = "An Aparitie")]
        public int AnAparitie { get; set; }
        public string Gen { get; set; }
        public string Status { get; set; }


    }
}
