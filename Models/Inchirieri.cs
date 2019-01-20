using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTVBookRental.Models
{
    public class Inchirieri
    {
        public int IdInchiriere { get; set; }
        public string ISBN { get; set; }

        [Display(Name = "Numar Matricol")]
        public string NumarMatricol { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Inceput")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Final")]
        public DateTime EndDate { get; set; }
            
        public virtual Student Student { get; set; }
    }
}
