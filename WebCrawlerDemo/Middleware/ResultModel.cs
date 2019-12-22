using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWP.WebCrawler.Middleware
{
    public enum StatusEnums
    {
        SUCCESS,
        SKIPPED,
        ERROR
    }

    public class ResultModel
    {
        public string Address { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsSkipped { get; set; }
        public bool IsError { get; set; }
    }
}
