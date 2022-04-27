namespace BelPomagalo.Utility
{
    public class Helper
    {
        public static void LoadListBoxData(ListBox listBox, IEnumerable<string> data, bool selectTheFirstItem = true)
        {
            listBox.Items.Clear();

            if (data != null && data.Count() != 0)
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
        public static void LoadComboBoxData(ComboBox comboBox, IEnumerable<string> data, bool selectTheFirstItem = true)
        {
            comboBox.Items.Clear();

            if (data != null && data.Count() != 0)
            {
                foreach (var item in data)
                {
                    comboBox.Items.Add(item);
                }

                if (selectTheFirstItem)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
        }
    }
}
