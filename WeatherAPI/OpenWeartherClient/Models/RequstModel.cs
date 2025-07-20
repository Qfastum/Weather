using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeartherClient.Models
{
    public class RequstModel
    {
        public string RequstUrl {  get; set; }
        public HttpMethod HttpMethod { get; set; }
        //public object Body { get; set; }
    }
}
