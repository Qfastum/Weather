using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeartherClient.Contracts
{
    public class WeatherContract
    {
        public string Main { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; } 
    }
}
