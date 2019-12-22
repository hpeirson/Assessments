using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HWP.WebCrawler.Middleware
{
    public static class Crawler
    {

        public static List<PageModel> GetPageList(string loc)
        {            
            var obj = CrawlHelper.JsonToObject<PagesResponse>(loc);
            var rows = (from m in obj.Pages
                        select new PageModel
                        {
                            Address = m.Address,
                            IsSeedURL = true,
                            PageLinks = m.Links.ToList()
                        }).Union(from m in obj.Pages.SelectMany(x => x.Links.Select(
                            s => new PageModel
                            {
                                Address = s,
                                IsSeedURL = false
                            }))
                                 group m by m.Address into g
                                 select g.First()).ToList();

            var flat = (from m in rows
                        group m by m.Address into g
                        select g.First()).ToList();

            return flat;

        }

        public static List<ResultModel> ProcessCrawl(string loc)
        {
            var rows = Crawler.GetPageList(loc);

            List<string> visited = new List<string>();
            List<string> skipped = new List<string>();
            foreach (var p in rows)
            {
                if (!p.IsSeedURL)
                    continue;

                if (!visited.Contains(p.Address))
                    visited.Add(p.Address);
               
                if (p.PageLinks != null)
                {
                    foreach (var lnk in p.PageLinks)
                    {
                        if (!visited.Contains(lnk))
                            visited.Add(lnk);
                        else
                            skipped.Add(lnk);
                    }
                }
            }

            var results = (from m in rows
                           select new ResultModel
                           {
                               Address = m.Address,
                               IsSkipped = (skipped.Contains(m.Address)),
                               IsSuccess = (m.IsSeedURL),
                               IsError = (!m.IsSeedURL)
                           }).ToList();

            return results;
        }

    }
}
