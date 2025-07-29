namespace InitalUI
{
    partial class LoginForm
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
            Username = new TextBox();
            Password = new TextBox();
            SignInbtn = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Username.Location = new Point(12, 12);
            Username.Name = "Username";
            Username.Size = new Size(341, 31);
            Username.TabIndex = 0;
            Username.Text = "Enter Your Username...";
            Username.TextAlign = HorizontalAlignment.Center;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Password.Location = new Point(12, 49);
            Password.Name = "Password";
            Password.Size = new Size(341, 31);
            Password.TabIndex = 1;
            Password.Text = "Enter Your Password...";
            Password.TextAlign = HorizontalAlignment.Center;
            // 
            // SignInbtn
            // 
            SignInbtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignInbtn.Location = new Point(12, 98);
            SignInbtn.Name = "SignInbtn";
            SignInbtn.Size = new Size(341, 34);
            SignInbtn.TabIndex = 2;
            SignInbtn.Text = "Sign In";
            SignInbtn.UseVisualStyleBackColor = true;
            SignInbtn.Click += SignInbtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 214);
            Controls.Add(SignInbtn);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Button SignInbtn;
    }
}