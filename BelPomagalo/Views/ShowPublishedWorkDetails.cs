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
    public partial class ShowPublishedWorkDetails : Form
    {
        public ShowPublishedWorkDetails()
        {
            InitializeComponent();
        }

        public ShowPublishedWorkDetails(string name, string authorName, IEnumerable<string> genreNames,IEnumerable<string> themeNames) : this()
        {
            nameLabel.Text = name;
            authorLabel.Text = authorName;
            genreLabel.Text = string.Join(", ",genreNames);
            themeLabel.Text = string.Join(", ",themeNames);
        }
    }
}
