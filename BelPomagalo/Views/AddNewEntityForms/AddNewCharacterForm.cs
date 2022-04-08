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
    public partial class AddNewCharacterForm : Form
    {
        public AddNewCharacterForm()
        {
            InitializeComponent();
        }
        public TextBox CharacterNameTextBox { get => characterNameTextBox; }
        public TextBox CharacterDescriptionTextBox { get => descriptionTextBox; }
        public ListBox AuthorListBox { get => authorListBox; }
        public Button AddNewCharacterButton { get => addNewCharacterButton; }
    }
}
