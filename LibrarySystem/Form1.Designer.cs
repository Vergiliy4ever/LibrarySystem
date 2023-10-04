namespace LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerTextBox
            // 
            this.registerTextBox.Location = new System.Drawing.Point(246, 116);
            this.registerTextBox.Name = "registerTextBox";
            this.registerTextBox.Size = new System.Drawing.Size(125, 27);
            this.registerTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(246, 149);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTextBox.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(246, 182);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(125, 29);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "button1";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.registerTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox registerTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
    }
}