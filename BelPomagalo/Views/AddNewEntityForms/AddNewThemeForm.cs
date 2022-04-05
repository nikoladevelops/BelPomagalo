using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelPomagalo.Views
{
    public partial class AddNewThemeForm : Form
    {
        public AddNewThemeForm()
        {
            InitializeComponent();
        }
        public TextBox ThemeNameTextBox { get => themeNameTextBox; }
        public TextBox ThemeDescriptionTextBox { get => descriptionTextBox; }
        public Button AddNewThemeButton { get => addNewThemeButton; }
    }
}
