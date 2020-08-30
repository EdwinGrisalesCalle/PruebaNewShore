using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Flight
    {
        public int id { get; set; }
        public string DeputareStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime DepurateDate { get; set; }
        public Transport Transport { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
    }
}