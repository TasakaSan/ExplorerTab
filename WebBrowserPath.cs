using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/// <summary>
/// Class containing methods to set WebBrowser
/// </summary>
/// 

namespace ExplorerTab
{
    class WebBrowserPath
    {
        public static void SetPathToWebBrowserQuickAccess(string name, ListView listView, WebBrowser webBrowser, TextBox textBox)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo _path = new System.Diagnostics.ProcessStartInfo();
                _path.FileName = listView.SelectedItems[0].Text;

                if (name == "Desktop")
                {
                    webBrowser.Url = new Uri(KnownFolders.GetPath(KnownFolder.Desktop));
                }
                else if (name == "Download")
                {
                    webBrowser.Url = new Uri(KnownFolders.GetPath(KnownFolder.Downloads));
                }
                else if (name == "Documents")
                {
                    webBrowser.Url = new Uri(KnownFolders.GetPath(KnownFolder.Documents));
                }
                else if (name == "Pictures")
                {
                    webBrowser.Url = new Uri(KnownFolders.GetPath(KnownFolder.Pictures));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public static void SetPathToWebBrowserDisk(ListView listView, WebBrowser webBrowser)
        {
            string str = listView.SelectedItems[0].ToString();
            int pFrom = str.IndexOf("(");
            int pTo = str.LastIndexOf(")");
            string result = str.Substring(pFrom +1 , (pTo-1) - pFrom);
            webBrowser.Url = new Uri(result);
        }

        public static void WebBroserSetTextBox(WebBrowser webBrowser, TextBox textBox)
        {
            if (webBrowser.Url != null)
            {
                string directoryPath = webBrowser.Url.AbsoluteUri.ToString();
                string strSubString = directoryPath.Substring(8);
                strSubString = Regex.Replace(strSubString, "%20", " ");
                textBox.Text = strSubString;
            }
            else textBox.Text = "";
        }

        public static void SetLabel(ToolStripStatusLabel label, WebBrowser webBrowser)
        {
            try
            {
                if(webBrowser.Url != null)
                {
                    string path = webBrowser.Url.AbsoluteUri.ToString();
                    string strSubString = path.Substring(8);
                    strSubString = Regex.Replace(strSubString, "%20", " ");

                    int directoryCount = System.IO.Directory.GetDirectories(strSubString).Length;
                    int fCount = Directory.GetFiles(strSubString).Length;

                    if (directoryCount > 1 || fCount > 1)
                    {
                        label.Text = directoryCount.ToString() + " Directory " + fCount.ToString() + " Files";
                    }
                    else label.Text = "0 Item";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
