using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMovies.Models
{
    public class ShippingInfo
    {
        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a zip code")]
        public string Zip { get; set; }
    }
}