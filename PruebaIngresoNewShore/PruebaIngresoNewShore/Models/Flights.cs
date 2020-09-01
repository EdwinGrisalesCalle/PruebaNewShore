using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaIngresoNewShore.Models
{
    public class Flights
    {
        public int id { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepurateDate { get; set; }
        public Transport Transport { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }

    }
}