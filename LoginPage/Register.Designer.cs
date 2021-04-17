namespace LoginPage
{
    partial class Register
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
            this.lbl_create = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_passconfirm = new System.Windows.Forms.TextBox();
            this.lbl_passconfirm = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_have = new System.Windows.Forms.Label();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_create
            // 
            this.lbl_create.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_create.AutoSize = true;
            this.lbl_create.BackColor = System.Drawing.Color.Transparent;
            this.lbl_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_create.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_create.ForeColor = System.Drawing.Color.Lime;
            this.lbl_create.Location = new System.Drawing.Point(106, 22);
            this.lbl_create.Name = "lbl_create";
            this.lbl_create.Size = new System.Drawing.Size(277, 29);
            this.lbl_create.TabIndex = 0;
            this.lbl_create.Text = "Create Your Account ";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_username.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Lime;
            this.lbl_username.Location = new System.Drawing.Point(82, 100);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(90, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(80, 138);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(303, 31);
            this.tb_username.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(80, 235);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(303, 31);
            this.tb_email.TabIndex = 4;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_email.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Lime;
            this.lbl_email.Location = new System.Drawing.Point(82, 202);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(54, 20);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(80, 334);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(303, 31);
            this.tb_password.TabIndex = 6;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_password.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Lime;
            this.lbl_password.Location = new System.Drawing.Point(82, 297);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(84, 20);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            // 
            // tb_passconfirm
            // 
            this.tb_passconfirm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passconfirm.Location = new System.Drawing.Point(80, 433);
            this.tb_passconfirm.Multiline = true;
            this.tb_passconfirm.Name = "tb_passconfirm";
            this.tb_passconfirm.PasswordChar = '•';
            this.tb_passconfirm.Size = new System.Drawing.Size(303, 31);
            this.tb_passconfirm.TabIndex = 8;
            // 
            // lbl_passconfirm
            // 
            this.lbl_passconfirm.AutoSize = true;
            this.lbl_passconfirm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_passconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_passconfirm.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passconfirm.ForeColor = System.Drawing.Color.Lime;
            this.lbl_passconfirm.Location = new System.Drawing.Point(82, 392);
            this.lbl_passconfirm.Name = "lbl_passconfirm";
            this.lbl_passconfirm.Size = new System.Drawing.Size(153, 20);
            this.lbl_passconfirm.TabIndex = 7;
            this.lbl_passconfirm.Text = "Confirm Password";
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.Lime;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signup.Location = new System.Drawing.Point(155, 529);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(166, 44);
            this.btn_signup.TabIndex = 9;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // cb_showpass
            // 
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.BackColor = System.Drawing.Color.Transparent;
            this.cb_showpass.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showpass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_showpass.Location = new System.Drawing.Point(254, 479);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(129, 21);
            this.cb_showpass.TabIndex = 10;
            this.cb_showpass.Text = "Show Password";
            this.cb_showpass.UseVisualStyleBackColor = false;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.cb_showpass_CheckedChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(155, 595);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(166, 44);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_have
            // 
            this.lbl_have.AutoSize = true;
            this.lbl_have.BackColor = System.Drawing.Color.Transparent;
            this.lbl_have.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_have.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_have.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_have.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_have.Location = new System.Drawing.Point(125, 684);
            this.lbl_have.Name = "lbl_have";
            this.lbl_have.Size = new System.Drawing.Size(243, 26);
            this.lbl_have.TabIndex = 12;
            this.lbl_have.Text = "Already Have an Account?";
            this.lbl_have.Click += new System.EventHandler(this.lbl_have_Click);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimize.Image = global::LoginPage.Properties.Resources.minimize_window_24;
            this.pb_minimize.Location = new System.Drawing.Point(420, 2);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(20, 20);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_minimize.TabIndex = 13;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // pb_close
            // 
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = global::LoginPage.Properties.Resources.cancel;
            this.pb_close.Location = new System.Drawing.Point(446, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(20, 20);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 14;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(468, 745);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.pb_minimize);
            this.Controls.Add(this.lbl_have);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cb_showpass);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.tb_passconfirm);
            this.Controls.Add(this.lbl_passconfirm);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_create;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_passconfirm;
        private System.Windows.Forms.Label lbl_passconfirm;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.CheckBox cb_showpass;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_have;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
    }
}