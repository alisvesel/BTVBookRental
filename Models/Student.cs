using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTVBookRental.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Display(Name ="Numele studentului")]
        public string NumePrenume { get; set; }

        [Display(Name = "Numar Matricol")]
        public string NumarMatricol { get; set; }
        public string Specializarea { get; set; }


    }
}
