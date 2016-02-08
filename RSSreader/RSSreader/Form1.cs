using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace RSSreader
{
    public partial class Form1 : Form
    {
        RssFeed CurrentFeed;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Url_textBox.Text))
            {
                Rss_list.Clear();
                CurrentFeed = new RssFeed(Url_textBox.Text);
                foreach (RssItem feedItem in CurrentFeed.Items)
                {
                    ListViewItem listViewItem = new ListViewItem(feedItem.title);
                    listViewItem.Name = feedItem.title;
                    listViewItem.ToolTipText = feedItem.pubdate;
                    Rss_list.Items.Add(listViewItem);

                }

            }
        }
        

        private void Rss_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Rss_list.SelectedItems.Count > 0 && CurrentFeed != null )
            {
                Description_webBrowser.DocumentText = CurrentFeed.Items.GetItem(Rss_list.SelectedItems[0].Text).description;
            }
        }

        private void Rss_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Description_webBrowser.Navigate(CurrentFeed.Items.GetItem(Rss_list.SelectedItems[0].Text).link);
        }
    }
}
