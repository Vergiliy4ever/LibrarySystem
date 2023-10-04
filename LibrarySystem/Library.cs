using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        public void User()
        {
            this.Width = this.Width / 2;
            usersListBox.Visible = false;
            usersListBox.Enabled = false;

            bookNameTextBox.Visible = false;
            bookNameTextBox.Enabled = false;

            bookAuthorLabel.Visible = false;
            bookAuthorLabel.Enabled = false;

            bookNameLabel.Visible = false;
            bookNameLabel.Enabled = false;

            booksListBox.Visible = false;
            booksListBox.Enabled = false;

            addBookButton.Visible = false;
            addBookButton.Enabled = false;

            deleteBookButton.Visible = false;
            deleteBookButton.Enabled = false;

            usersListBox.Visible = false;
            usersListBox.Enabled = false;

            usersListBox.Visible = false;
            usersListBox.Enabled = false;
        }
        private void bookNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
