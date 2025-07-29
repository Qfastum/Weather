using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GismetioClient.Models
{
    public class RequstGismetioModel
    {
        public string RequstUrl { get; set; }

        public HttpMethod httpMethod { get; set; }

        public string HeaderName { get; set; }

        public string HeaderValue { get; set; }  
    }
}
