namespace LoginPage
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
            this.lbl_dont = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_signin = new System.Windows.Forms.Label();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.lbl_enjoy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dont
            // 
            this.lbl_dont.AutoSize = true;
            this.lbl_dont.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dont.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dont.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_dont.Location = new System.Drawing.Point(123, 560);
            this.lbl_dont.Name = "lbl_dont";
            this.lbl_dont.Size = new System.Drawing.Size(224, 26);
            this.lbl_dont.TabIndex = 25;
            this.lbl_dont.Text = "Don\'t Have an Account?\r\n";
            this.lbl_dont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dont.Click += new System.EventHandler(this.lbl_dont_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(140, 460);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(166, 44);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cb_showpass
            // 
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.BackColor = System.Drawing.Color.Transparent;
            this.cb_showpass.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showpass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_showpass.Location = new System.Drawing.Point(252, 322);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(126, 21);
            this.cb_showpass.TabIndex = 23;
            this.cb_showpass.Text = "Show Password";
            this.cb_showpass.UseVisualStyleBackColor = false;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.cb_showpass_CheckedChanged);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.Lime;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signup.Location = new System.Drawing.Point(140, 394);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(166, 44);
            this.btn_signup.TabIndex = 22;
            this.btn_signup.Text = "Sign In";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(78, 276);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(303, 27);
            this.tb_password.TabIndex = 21;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Lime;
            this.lbl_password.Location = new System.Drawing.Point(74, 241);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(81, 21);
            this.lbl_password.TabIndex = 20;
            this.lbl_password.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(78, 179);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(303, 27);
            this.tb_username.TabIndex = 15;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_username.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Lime;
            this.lbl_username.Location = new System.Drawing.Point(74, 145);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(85, 21);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "Username";
            // 
            // lbl_signin
            // 
            this.lbl_signin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_signin.AutoSize = true;
            this.lbl_signin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_signin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signin.ForeColor = System.Drawing.Color.Lime;
            this.lbl_signin.Location = new System.Drawing.Point(182, 9);
            this.lbl_signin.Name = "lbl_signin";
            this.lbl_signin.Size = new System.Drawing.Size(99, 29);
            this.lbl_signin.TabIndex = 13;
            this.lbl_signin.Text = "Sign in";
            // 
            // pb_minimize
            // 
            this.pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimize.Image = global::LoginPage.Properties.Resources.minimize_window_icon_14_24;
            this.pb_minimize.Location = new System.Drawing.Point(402, 2);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(20, 20);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_minimize.TabIndex = 27;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // pb_close
            // 
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = global::LoginPage.Properties.Resources.cancel;
            this.pb_close.Location = new System.Drawing.Point(428, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(20, 20);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 26;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // lbl_enjoy
            // 
            this.lbl_enjoy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_enjoy.AutoSize = true;
            this.lbl_enjoy.BackColor = System.Drawing.Color.Transparent;
            this.lbl_enjoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_enjoy.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enjoy.ForeColor = System.Drawing.Color.Lime;
            this.lbl_enjoy.Location = new System.Drawing.Point(152, 38);
            this.lbl_enjoy.Name = "lbl_enjoy";
            this.lbl_enjoy.Size = new System.Drawing.Size(185, 29);
            this.lbl_enjoy.TabIndex = 28;
            this.lbl_enjoy.Text = "Enjoy the App";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 634);
            this.Controls.Add(this.lbl_enjoy);
            this.Controls.Add(this.pb_minimize);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.lbl_dont);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cb_showpass);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_signin);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dont;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.CheckBox cb_showpass;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_signin;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.Label lbl_enjoy;
    }
}

