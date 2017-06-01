using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;
using TP4.Model;

namespace TP4.DataAccess
{
    public class Flux 
    {
       
        public Flux()
        {
            
        }

        public List<MyFlux> GetflMyFluxs(String path)
        {
            List<MyFlux> res = new List<MyFlux>();
            XDocument xdoc = XDocument.Load(path);
            var querry = from e in xdoc.Descendants()
                         select e;
            foreach (XElement element in querry)
            {
                res.Add(new MyFlux(){Name = element.Element("name")?.Value, Url = element.Element("url")?.Value});
            }
            return res;
        }

        public List<SyndicationItem> GetItems(String url)
        {
            String urlFluxRss = url;            // http://www.developpez.com/index/rss; 
            Uri serviceAddress = new Uri(urlFluxRss);
            XmlReader reader = XmlReader.Create(urlFluxRss); 
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            if (feed != null)
            {
                var querry = from e in feed.Items
                    select e;
                return querry.ToList();
            }
            return new List<SyndicationItem>();
        }
    }
}