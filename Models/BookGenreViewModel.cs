using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTVBookRental.Models
{
    public class BookGenreViewModel
    {
        public List<Book> Books;
        public SelectList Gen;
        public string BookGen { get; set; }
        public string SearchString { get; set; }
    }
}
