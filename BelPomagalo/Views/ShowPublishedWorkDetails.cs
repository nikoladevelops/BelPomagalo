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

        public ShowPublishedWorkDetails(string name, string genreName, string authorName, string themeName) : this()
        {
            nameLabel.Text = name;
            genreLabel.Text = genreName;
            authorLabel.Text = authorName;
            themeLabel.Text = themeName;
        }
    }
}
