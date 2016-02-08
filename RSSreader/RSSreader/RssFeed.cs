using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;


namespace RSSreader
{
    class RssFeed
    {
        public String Title;
        public String Description;
        public String Link;
        public RssItems Items;
        public String pubDate;

        public RssFeed(String Url)
        {
            Items = new RssItems();
            XmlTextReader xmlTextReader = new XmlTextReader(Url);
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(xmlTextReader);
                xmlTextReader.Close();
                XmlNode channelXmlNode = xmlDoc.GetElementsByTagName("channel")[0];
                if (channelXmlNode != null)
                {
                    foreach (XmlNode channelNode in channelXmlNode)
                    {
                        switch (channelNode.Name)
                        {
                            case "title":
                                {
                                    Title = channelNode.InnerText;
                                    break;
                                }
                            case "description":
                                {
                                    Description = channelNode.InnerText;
                                    break;
                                }
                            case "link":
                                {
                                    Link = channelNode.InnerText;
                                    break;
                                }
                            case "item":
                                {
                                    RssItem channelItem = new RssItem(channelNode);
                                    Items.Add(channelItem);
                                    break;
                                }
                            case "pubDate":
                                {
                                    pubDate = channelNode.InnerText;
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    throw new Exception("Error in XML, channel description not found!");
                }
            }

            catch (System.Net.WebException ex)
            {
                if (ex.Status == System.Net.WebExceptionStatus.NameResolutionFailure)
                    throw new Exception("Impossible to connect with source.\r\n" + Url);
                else
                    throw
                       ex;
            }

            catch (System.IO.FileNotFoundException)
            {
                throw new Exception("File" + Url + "not found");
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                xmlTextReader.Close();
            }

            }
       
    }
}
