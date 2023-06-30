namespace LinqSqlProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameDropdown = new System.Windows.Forms.ComboBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UsernameLabel.Location = new System.Drawing.Point(149, 84);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(130, 29);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameDropdown
            // 
            this.UsernameDropdown.FormattingEnabled = true;
            this.UsernameDropdown.Location = new System.Drawing.Point(120, 138);
            this.UsernameDropdown.Name = "UsernameDropdown";
            this.UsernameDropdown.Size = new System.Drawing.Size(179, 24);
            this.UsernameDropdown.TabIndex = 0;
            this.UsernameDropdown.SelectedIndexChanged += new System.EventHandler(this.UsernameDropdown_SelectedIndexChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.Location = new System.Drawing.Point(267, 235);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(235, 74);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(512, 84);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(126, 29);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(470, 140);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(201, 22);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameDropdown);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ComboBox UsernameDropdown;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
    }
}