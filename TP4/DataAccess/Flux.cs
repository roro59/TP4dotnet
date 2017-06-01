using System;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;

namespace TP4.DataAccess
{
    public class Flux : IDisposable
    {
        private String urlFluxRss;
        private XmlReader reader;
        public void Dispose()
        {
            reader.Dispose();
        }

        public void Initialize()
        {
            reader = XmlReader.Create(urlFluxRss);
        }

        public Flux(String url)
        {
            urlFluxRss = url; // "http://www.developpez.com/index/rss";
            XDocument doc = XDocument.Load(reader);
            var querry = from t in doc.Descendants("flux")
                         select t;
                
        }
    }
}