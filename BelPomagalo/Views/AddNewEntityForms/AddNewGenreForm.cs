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
    public partial class AddNewGenreForm : Form
    {
        public AddNewGenreForm()
        {
            InitializeComponent();
        }
        public TextBox GenreNameTextBox { get => genreNameTextBox; }
        public TextBox GenreDescriptionTextBox { get => descriptionTextBox; }
        public Button AddNewGenreButton { get => addNewGenreButton; }
    }
}
