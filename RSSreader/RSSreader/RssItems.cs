using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSreader
{

    class RssItems : List<RssItem>
    {
        new public bool Contains(RssItem Item)
        {
            foreach (RssItem ItemForCheck in this)
            {
                if (Item.title == ItemForCheck.title)
                {
                    return true;
                }
            }
            return false;
        
        }

        public RssItem GetItem(string title)
        {
            foreach (RssItem itemForCheck in this)
            {
                if (itemForCheck.title ==  title)
                {
                    return itemForCheck;
                }

            }
            return null;
        }
        

    }
}
