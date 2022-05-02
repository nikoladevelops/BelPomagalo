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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        public ListBox EntityListBox { get => entityListBox; }
        public Panel EditPanel { get => editPanel; }
        public Label EntityLabel { get => entityLabel; }
    }
}
