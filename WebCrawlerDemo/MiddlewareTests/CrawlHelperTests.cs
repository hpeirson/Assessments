using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWP.WebCrawler.Middleware;
using System.Collections;

namespace TestMiddleware
{
    [TestClass]
    public class CrawlHelperTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestJsonToObject()
        {
            string fl = Path.Combine(Environment.CurrentDirectory, "MockData", "internet1.json");
            var obj = CrawlHelper.JsonToObject<PagesResponse>(fl);
            Assert.AreEqual(5, obj.Pages.Length);
        }

        [TestMethod]
        public void TestJsonToModel()
        {
            string fl = Path.Combine(Environment.CurrentDirectory, "MockData", "internet1.json");
            var obj = CrawlHelper.JsonToObject<PagesResponse>(fl);
            var rows = (from m in obj.Pages
                       select new PageModel
                       {
                           Address = m.Address,
                           IsSeedURL = true
                       }).ToList();

            Assert.AreEqual(5, rows.Count());
        }

        [TestMethod]
        public void TestToPageModelList()
        {
            string fl = Path.Combine(Environment.CurrentDirectory, "MockData", "internet1.json");
            var obj = CrawlHelper.JsonToObject<PagesResponse>(fl);
            var rows = (from m in obj.Pages
                       select new PageModel
                       {
                           Address = m.Address,
                           IsSeedURL = true
                       }).ToList();
            
            Assert.AreEqual(5, rows.Count());
        }
        
        [TestMethod]
        public void TestPageModelLinksList()
        {
            string fl = Path.Combine(Environment.CurrentDirectory, "MockData", "internet1.json");
            var obj = CrawlHelper.JsonToObject<PagesResponse>(fl);
            var rows = (from m in obj.Pages.SelectMany(x => x.Links.Select(
                        s => new PageModel
                        {
                            Address = s,
                            IsSeedURL = false
                        }).ToList())
                        group m by m.Address into g
                        select g.First()).ToList();

            Assert.AreEqual(7, rows.Count());
        }
        
        [TestMethod]
        public void TestGetPageList()
        {
            string fl = Path.Combine(Environment.CurrentDirectory, "MockData", "internet1.json");
            var rows = Crawler.GetPageList(fl);
            Assert.AreEqual(7, rows.Count());
        }
        
        [TestMethod]
        public void TestProcessCrawl()
        {
            string fl = Path.Combine(Environment.CurrentDirectory, "MockData", "internet1.json");
            var rows = Crawler.ProcessCrawl(fl);            
            Assert.AreEqual(7, rows.Count());
        }
    }
}
