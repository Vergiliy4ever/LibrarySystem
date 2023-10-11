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
            usersListBox.Visible = false;
            usersListBox.Enabled = false;

            bookAuthorTextBox.Visible = false;
            bookAuthorTextBox.Enabled = false;

            bookYearTextBox.Visible = false;
            bookYearTextBox.Enabled = false;

            bookYearLabel.Visible = false;
            bookYearLabel.Enabled = false;

            bookNameTextBox.Visible = false;
            bookNameTextBox.Enabled = false;

            bookAuthorLabel.Visible = false;
            bookAuthorLabel.Enabled = false;

            bookNameLabel.Visible = false;
            bookNameLabel.Enabled = false;

            addBookButton.Visible = false;
            addBookButton.Enabled = false;

            deleteBookButton.Visible = false;
            deleteBookButton.Enabled = false;

            usersListBox.Visible = false;
            usersListBox.Enabled = false;

            usersListBox.Visible = false;
            usersListBox.Enabled = false;
        }

        public void Admin()
        {
            usersListBox.Visible = true;
            usersListBox.Enabled = true;

            bookAuthorTextBox.Visible = true;
            bookAuthorTextBox.Enabled = true;

            bookYearTextBox.Visible = true;
            bookYearTextBox.Enabled = true;

            bookYearLabel.Visible = true;
            bookYearLabel.Enabled = true;

            bookNameTextBox.Visible = true;
            bookNameTextBox.Enabled = true;

            bookAuthorLabel.Visible = true;
            bookAuthorLabel.Enabled = true;

            bookNameLabel.Visible = true;
            bookNameLabel.Enabled = true;

            addBookButton.Visible = true;
            addBookButton.Enabled = true;

            deleteBookButton.Visible = true;
            deleteBookButton.Enabled = true;

            usersListBox.Visible = true;
            usersListBox.Enabled = true;

            usersListBox.Visible = true;
            usersListBox.Enabled = true;
        }

        private void bookNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
