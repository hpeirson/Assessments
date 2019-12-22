using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HWP.WebCrawler.Middleware
{
    public class Page
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("links")]
        public string[] Links { get; set; }
    }

    public class PagesResponse
    {

        [JsonProperty("pages")]
        public Page[] Pages { get; set; }
    }
}