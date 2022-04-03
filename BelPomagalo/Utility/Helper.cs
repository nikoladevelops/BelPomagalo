using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Utility
{
    internal class Helper
    {
        internal static void LoadListBoxData(ListBox listBox, IEnumerable<string> data)
        {
            listBox.Items.Clear();

            if (data != null)
            {
                foreach (var item in data)
                {
                    listBox.Items.Add(item);
                }
                listBox.SelectedIndex = 0;
            }
        }
    }
}
