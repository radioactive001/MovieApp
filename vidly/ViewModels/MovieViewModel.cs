using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModels
{
    public class MovieViewModel
    {
        public Movie movie { get; set; }
        public List<Movie> Movies { get; set; }
        
    }
}