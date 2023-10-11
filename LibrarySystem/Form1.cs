namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            Library f2 = new Library();
            f2.User();
            f2.Show();
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            Library f2 = new Library();
            f2.Admin();
            f2.Show();
            this.Hide();
            
        }


    }
}