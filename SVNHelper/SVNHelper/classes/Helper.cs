using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpSvn;
using SVNProjectList;

namespace Helper.Classes
{
    public class Helper
    {
        private SvnClient client = null;
        private const string SVNURL = "https://svntogether.greco.eu/svn/{0}/trunk/{1}";

        public Helper()
        {
            client = new SvnClient();
        }
        public Helper(string svnUsername, string svnPassword)
        {
            client = new SvnClient();
            client.Authentication.ForceCredentials(svnUsername, svnPassword);
        }

        public void svnAuthen(string svnUsername, string svnPassword)
        {
            client.Authentication.ForceCredentials(svnUsername, svnPassword);
        }

        public static List<string> getSelectedItems(ListBox lsb)
        {
            List<string> newItems = new List<string>();

            foreach (String item in lsb.SelectedItems)
            {
                newItems.Add(item);
            }

            return newItems;
        }

        public static List<string> getAllItems(ListBox lsb)
        {
            List<string> newItems = new List<string>();

            foreach (String item in lsb.Items)
            {
                newItems.Add(item);
            }

            return newItems;
        }

        public static void setListBoxItems(ListBox lsb, List<string> newItems)
        {
            List<string> oldItems = new List<string>();
            ListBox.ObjectCollection lsbItems = lsb.Items;
            
            foreach (string item in lsbItems)
            {
                oldItems.Add(item);
            }
            foreach (string item in newItems)
            {
                oldItems.Add(item);
            }
            oldItems.Sort();
            lsb.Items.Clear();
            
            foreach(string item in oldItems)
            {
                lsb.Items.Add(item);
            }
        }

        public static void moveItemsLeftToRight(ListBox lsbLeft, ListBox lsbRight)
        {
            AddItems(lsbLeft, lsbRight);
            removeItems(lsbLeft);
        }

        public static void moveItemsRightToleft(ListBox lsbLeft, ListBox lsbRight)
        {
            AddItems(lsbRight, lsbLeft);
            removeItems(lsbRight);
        }

        private static void AddItems(ListBox lsbSrc, ListBox lsbDes)
        {
            setListBoxItems(lsbDes, getSelectedItems(lsbSrc));
        }

        private static void removeItems(ListBox lsbSrc)
        {
            List<string> items = getSelectedItems(lsbSrc);
            foreach (string item in items)
            {
                lsbSrc.Items.Remove(item);
            }
        }

        public static List<string> getSVNItems()
        {
            return ProjectList.getSVNProjectList();
        }

        public void doCheckOut(string project, string path)
        {
            client.CheckOut(new Uri(String.Format(SVNURL, project, project)), String.Concat(path, "/", project));
        }
    }
}
