using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Utility
{
    internal class Helper
    {
        internal static void LoadListBoxData(ListBox listBox, IEnumerable<string> data, bool selectTheFirstItem = true)
        {
            listBox.Items.Clear();

            if (data != null)
            {
                foreach (var item in data)
                {
                    listBox.Items.Add(item);
                }

                if (selectTheFirstItem)
                {
                    listBox.SelectedIndex = 0;
                }
            }
        }
    }
}
