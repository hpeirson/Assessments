using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWP.WebCrawler.Middleware
{
    public class PageModel
    {        
        public string Address { get; set; }
        public bool IsSeedURL { get; set; }
        public List<string> PageLinks { get; set; }
        public string PageData { get; set; }       
    }
}

