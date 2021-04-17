namespace LoginPage
{
    partial class Publish
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
            this.tb_publish = new System.Windows.Forms.TextBox();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.pb_logout = new System.Windows.Forms.PictureBox();
            this.pb_maximize = new System.Windows.Forms.PictureBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_publish
            // 
            this.tb_publish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_publish.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_publish.Location = new System.Drawing.Point(2, 1);
            this.tb_publish.Multiline = true;
            this.tb_publish.Name = "tb_publish";
            this.tb_publish.Size = new System.Drawing.Size(768, 597);
            this.tb_publish.TabIndex = 31;
            // 
            // btn_write
            // 
            this.btn_write.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_write.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_write.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_write.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_write.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.Color.White;
            this.btn_write.Location = new System.Drawing.Point(809, 54);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(123, 53);
            this.btn_write.TabIndex = 32;
            this.btn_write.Text = "Write ";
            this.btn_write.UseVisualStyleBackColor = false;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(809, 214);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(123, 53);
            this.btn_clear.TabIndex = 33;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_open.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.Location = new System.Drawing.Point(809, 134);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(123, 53);
            this.btn_open.TabIndex = 34;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // pb_logout
            // 
            this.pb_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_logout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_logout.Image = global::LoginPage.Properties.Resources.exit;
            this.pb_logout.Location = new System.Drawing.Point(872, 538);
            this.pb_logout.Name = "pb_logout";
            this.pb_logout.Size = new System.Drawing.Size(60, 50);
            this.pb_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logout.TabIndex = 35;
            this.pb_logout.TabStop = false;
            this.pb_logout.Click += new System.EventHandler(this.pb_logout_Click);
            // 
            // pb_maximize
            // 
            this.pb_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_maximize.Image = global::LoginPage.Properties.Resources.maximize_window_24;
            this.pb_maximize.Location = new System.Drawing.Point(872, 1);
            this.pb_maximize.Name = "pb_maximize";
            this.pb_maximize.Size = new System.Drawing.Size(20, 20);
            this.pb_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_maximize.TabIndex = 30;
            this.pb_maximize.TabStop = false;
            this.pb_maximize.Click += new System.EventHandler(this.pb_maximize_Click);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimize.Image = global::LoginPage.Properties.Resources.minimize_window_icon_14_24;
            this.pb_minimize.Location = new System.Drawing.Point(898, 1);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(20, 20);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_minimize.TabIndex = 29;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = global::LoginPage.Properties.Resources.cancel;
            this.pb_close.Location = new System.Drawing.Point(924, 1);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(20, 20);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 28;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // Publish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pb_logout);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.tb_publish);
            this.Controls.Add(this.pb_maximize);
            this.Controls.Add(this.pb_minimize);
            this.Controls.Add(this.pb_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Publish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publish";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_maximize;
        private System.Windows.Forms.TextBox tb_publish;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.PictureBox pb_logout;
    }
}