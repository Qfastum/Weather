using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeartherClient.Contracts
{
    public class WeatherResponseContract
    {
        public List<WeatherContract> Weather {get; set;}
        
        public WindContract Wind {get; set;}

        public MainWeatherContract Main {get; set;}

    }
}
