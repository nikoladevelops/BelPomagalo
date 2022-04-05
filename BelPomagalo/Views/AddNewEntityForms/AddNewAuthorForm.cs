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
    public partial class AddNewAuthorForm : Form
    {
        public AddNewAuthorForm()
        {
            InitializeComponent();
        }
        public TextBox AuthorNameTextBox { get => authorNameTextBox; }
        public TextBox AuthorDescriptionTextBox { get => descriptionTextBox; }
        public TextBox AuthorBornLocationTextBox { get => bornLocationTextBox; }
        public TextBox AuthorBornDateTextBox { get => bornDateTextBox; }
        public TextBox AuthorDiedDateTextBox { get => diedDateTextBox; }
        public Button AddNewAuthorButton { get => addNewAuthorButton; }
    }
}
