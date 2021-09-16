using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherClient.Models
{
    public class WeatherDetail
    {
        public int Wid { get; set; }
        public string City { get; set; }
        public int? Temperature { get; set; }
        public int? Humidity { get; set; }
        public int? Visibility { get; set; }
    }
}
