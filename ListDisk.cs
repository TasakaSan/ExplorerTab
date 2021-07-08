using System;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// Class containing methods to list disk on computer to listviewitem.
/// </summary>
/// 

namespace ExplorerTab
{
    class ListDisk
    {
        public static void CreateItemsInListViewQuickAccess(ListView listViewName, string name)
        {
            listViewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular);
            listViewName.Items.Add(name);
        }
        public static void CreateItemsInListViewListDisk(ListView list)
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo drives in allDrives)
                {
                    string diskVolume = drives.VolumeLabel;
                    string diskLetter = drives.Name;
                    list.FullRowSelect = true;
                    list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular);
                    list.Items.Add(diskVolume + " (" + diskLetter +")");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public static void SetToolStripSelectedItems(ToolStripStatusLabel statusLabel, WebBrowser webBrowser)
        {

        }
    }
}
