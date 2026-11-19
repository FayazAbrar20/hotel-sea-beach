namespace hotelseabeach
{
    partial class loginpage
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
            this.Registerbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.Paasword = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Registerbutton
            // 
            this.Registerbutton.AllowDrop = true;
            this.Registerbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registerbutton.Location = new System.Drawing.Point(324, 288);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(99, 30);
            this.Registerbutton.TabIndex = 0;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.AllowDrop = true;
            this.loginbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbutton.Location = new System.Drawing.Point(465, 288);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(99, 30);
            this.loginbutton.TabIndex = 1;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // username
            // 
            this.username.AllowDrop = true;
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(295, 170);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(103, 23);
            this.username.TabIndex = 2;
            this.username.Text = "User Name";
            // 
            // Paasword
            // 
            this.Paasword.AllowDrop = true;
            this.Paasword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Paasword.AutoSize = true;
            this.Paasword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paasword.Location = new System.Drawing.Point(298, 230);
            this.Paasword.Name = "Paasword";
            this.Paasword.Size = new System.Drawing.Size(90, 23);
            this.Paasword.TabIndex = 3;
            this.Paasword.Text = "Password";
            this.Paasword.Click += new System.EventHandler(this.Paasword_Click);
            // 
            // t1
            // 
            this.t1.AllowDrop = true;
            this.t1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t1.BackColor = System.Drawing.SystemColors.Window;
            this.t1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.t1.Location = new System.Drawing.Point(416, 171);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(178, 28);
            this.t1.TabIndex = 4;
            this.t1.TextChanged += new System.EventHandler(this.logintextBox1_TextChanged);
            // 
            // t2
            // 
            this.t2.AllowDrop = true;
            this.t2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t2.BackColor = System.Drawing.SystemColors.Window;
            this.t2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.t2.Location = new System.Drawing.Point(417, 227);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(177, 28);
            this.t2.TabIndex = 5;
            this.t2.UseSystemPasswordChar = true;
            this.t2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AllowDrop = true;
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(600, 235);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 529);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.Paasword);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.Registerbutton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Paradise-Login";
            this.Load += new System.EventHandler(this.loginpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Paasword;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

