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
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }
        public ComboBox LiteratureComboBox { get => literatureComboBox; }
        public Button LiteratureAddButton { get => literatureAddButton; }
        public Button LiteratureEditButton { get => literatureEditButton; }

        public ComboBox BulgarianComboBox { get => bulgarianComboBox; }
        public Button BulgarianAddButton { get => bulgarianAddButton; }
        public Button BulgarianEditButton { get => bulgarianEditButton; }
    }
}
