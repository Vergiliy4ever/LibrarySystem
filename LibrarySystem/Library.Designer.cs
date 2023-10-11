namespace LibrarySystem
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookAuthorTextBox = new System.Windows.Forms.TextBox();
            this.bookYearTextBox = new System.Windows.Forms.TextBox();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.bookAuthorLabel = new System.Windows.Forms.Label();
            this.bookYearLabel = new System.Windows.Forms.Label();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 20;
            this.usersListBox.Location = new System.Drawing.Point(638, 12);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(587, 364);
            this.usersListBox.TabIndex = 0;
            this.usersListBox.UseTabStops = false;
            this.usersListBox.Visible = false;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Enabled = false;
            this.bookNameTextBox.Location = new System.Drawing.Point(638, 382);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.bookNameTextBox.TabIndex = 1;
            this.bookNameTextBox.Visible = false;
            this.bookNameTextBox.TextChanged += new System.EventHandler(this.bookNameTextBox_TextChanged);
            // 
            // bookAuthorTextBox
            // 
            this.bookAuthorTextBox.Enabled = false;
            this.bookAuthorTextBox.Location = new System.Drawing.Point(769, 382);
            this.bookAuthorTextBox.Name = "bookAuthorTextBox";
            this.bookAuthorTextBox.Size = new System.Drawing.Size(125, 27);
            this.bookAuthorTextBox.TabIndex = 2;
            this.bookAuthorTextBox.Visible = false;
            // 
            // bookYearTextBox
            // 
            this.bookYearTextBox.Enabled = false;
            this.bookYearTextBox.Location = new System.Drawing.Point(900, 382);
            this.bookYearTextBox.Name = "bookYearTextBox";
            this.bookYearTextBox.Size = new System.Drawing.Size(125, 27);
            this.bookYearTextBox.TabIndex = 3;
            this.bookYearTextBox.Visible = false;
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(12, 12);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(620, 564);
            this.booksListBox.TabIndex = 4;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.booksListBox_SelectedIndexChanged);
            // 
            // addBookButton
            // 
            this.addBookButton.Enabled = false;
            this.addBookButton.Location = new System.Drawing.Point(1031, 381);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(94, 29);
            this.addBookButton.TabIndex = 5;
            this.addBookButton.Text = "Добавить";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Visible = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Enabled = false;
            this.bookNameLabel.Location = new System.Drawing.Point(662, 412);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(77, 20);
            this.bookNameLabel.TabIndex = 6;
            this.bookNameLabel.Text = "Название";
            this.bookNameLabel.Visible = false;
            // 
            // bookAuthorLabel
            // 
            this.bookAuthorLabel.AutoSize = true;
            this.bookAuthorLabel.Enabled = false;
            this.bookAuthorLabel.Location = new System.Drawing.Point(806, 412);
            this.bookAuthorLabel.Name = "bookAuthorLabel";
            this.bookAuthorLabel.Size = new System.Drawing.Size(51, 20);
            this.bookAuthorLabel.TabIndex = 7;
            this.bookAuthorLabel.Text = "Автор";
            this.bookAuthorLabel.Visible = false;
            // 
            // bookYearLabel
            // 
            this.bookYearLabel.AutoSize = true;
            this.bookYearLabel.Enabled = false;
            this.bookYearLabel.Location = new System.Drawing.Point(949, 412);
            this.bookYearLabel.Name = "bookYearLabel";
            this.bookYearLabel.Size = new System.Drawing.Size(33, 20);
            this.bookYearLabel.TabIndex = 8;
            this.bookYearLabel.Text = "Год";
            this.bookYearLabel.Visible = false;
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Enabled = false;
            this.deleteBookButton.Location = new System.Drawing.Point(1131, 381);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(94, 29);
            this.deleteBookButton.TabIndex = 12;
            this.deleteBookButton.Text = "Удалить";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Visible = false;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 600);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.bookYearLabel);
            this.Controls.Add(this.bookAuthorLabel);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.bookYearTextBox);
            this.Controls.Add(this.bookAuthorTextBox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.usersListBox);
            this.Name = "Library";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox usersListBox;
        private TextBox bookNameTextBox;
        private TextBox bookAuthorTextBox;
        private TextBox bookYearTextBox;
        private ListBox booksListBox;
        private Button addBookButton;
        private Label bookNameLabel;
        private Label bookAuthorLabel;
        private Label bookYearLabel;
        private Button deleteBookButton;
    }
}