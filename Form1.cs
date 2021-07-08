using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExplorerTab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(((Screen.PrimaryScreen.Bounds.Width / 2) - this.Width), (((Screen.PrimaryScreen.Bounds.Height / 2) - this.Height) + 220));

            InitializeComponent();

            AddItemsToListDisk();
            AddItemsToQuickAcess();
        }

        private void FormTitle()
        {
            try
            {
                if (listViewQuickAccess.SelectedItems.Count > 0)
                {
                    this.Text = listViewQuickAccess.SelectedItems[0].Text;
                }
                else if (listViewListDisk.SelectedItems.Count > 0)
                {
                    this.Text = listViewListDisk.SelectedItems[0].Text;
                }
                else this.Text = "ExplorerTab";
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void listViewQuickAccess_SelectedIndexChanged(object sender, EventArgs e){ FormTitle(); }
        private void listViewListDisk_SelectedIndexChanged(object sender, EventArgs e){ FormTitle(); }
        private void listViewQuickAccess_Leave(object sender, EventArgs e)
        {
            this.listViewQuickAccess.SelectedItems.Clear();
        }
        private void AddItemsToQuickAcess()
        {
            ListDisk.CreateItemsInListViewQuickAccess(listViewQuickAccess, "Desktop");
            ListDisk.CreateItemsInListViewQuickAccess(listViewQuickAccess, "Download");
            ListDisk.CreateItemsInListViewQuickAccess(listViewQuickAccess, "Documents");
            ListDisk.CreateItemsInListViewQuickAccess(listViewQuickAccess, "Pictures");
        }
        private void AddItemsToListDisk()
        {
            ListDisk.CreateItemsInListViewListDisk(listViewListDisk);
        }

        ///Buttons Form
        private void btn_Back_Click(object sender, EventArgs e)
        {
            try
            {
                if (webBrowser1.CanGoBack) webBrowser1.GoBack();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
        private void btn_Forward_Click(object sender, EventArgs e)
        {
            try
            {
                if (webBrowser1.CanGoForward) webBrowser1.GoForward();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        /// List View Click Event
        private void listViewQuickAccess_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        {
                            WebBrowserPath.SetPathToWebBrowserQuickAccess(listViewQuickAccess.SelectedItems[0].Text, listViewQuickAccess, webBrowser1, tb_Path);
                        }
                        break;
                    case 1:
                        {
                            WebBrowserPath.SetPathToWebBrowserQuickAccess(listViewQuickAccess.SelectedItems[0].Text, listViewQuickAccess, webBrowser2, tb_Path);
                        }
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void listViewListDisk_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        {
                            WebBrowserPath.SetPathToWebBrowserDisk(listViewListDisk, webBrowser1);
                        }
                        break;
                    case 1:
                        {
                            WebBrowserPath.SetPathToWebBrowserDisk(listViewListDisk, webBrowser2);
                        }
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                WebBrowserPath.WebBroserSetTextBox(webBrowser1, tb_Path);
                WebBrowserPath.SetLabel(toolStripStatusLabel1, webBrowser1);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                WebBrowserPath.WebBroserSetTextBox(webBrowser2, tb_Path);
                WebBrowserPath.SetLabel(toolStripStatusLabel1, webBrowser2);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        {
                            WebBrowserPath.WebBroserSetTextBox(webBrowser1, tb_Path);
                            WebBrowserPath.SetLabel(toolStripStatusLabel1, webBrowser1);
                        }
                        break;
                    case 1:
                        {
                            WebBrowserPath.WebBroserSetTextBox(webBrowser2, tb_Path);
                            WebBrowserPath.SetLabel(toolStripStatusLabel1, webBrowser2);
                        }
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
