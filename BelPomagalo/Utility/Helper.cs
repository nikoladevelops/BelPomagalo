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
        public static void LoadListBoxData(ListBox listBox, IEnumerable<string> data, int selectIndex)
        {
            listBox.Items.Clear();

            if (data != null && data.Count() != 0)
            {
                foreach (var item in data)
                {
                    listBox.Items.Add(item);
                }

                if (listBox.Items.Count == 0)
                {
                    return;
                }

                if (listBox.Items.Count <= selectIndex)
                {
                    return;
                }

                listBox.SelectedIndex = selectIndex;
            }
        }
        public static void LoadListBoxData(ListBox listBox, IEnumerable<string> data, IEnumerable<string> elementsToSelect)
        {
            listBox.Items.Clear();

            if (data != null && data.Count() != 0)
            {
                foreach (var item in data)
                {
                    listBox.Items.Add(item);
                }

                foreach (var element in elementsToSelect)
                {
                    listBox.SelectedIndex = listBox.Items.IndexOf(element);
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

        public static bool CheckIfTextBoxesFilled(params TextBox[] textBoxes) 
        {
            foreach (var textbox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text)) 
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckIfListBoxesHaveSelectedIndex(params ListBox[] listBoxes)
        {
            foreach (var listBox in listBoxes)
            {
                if (listBox.SelectedIndex == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
