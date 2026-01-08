namespace Loginandregister
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            register = new Button();
            loginbutton = new Button();
            pictureBox1 = new PictureBox();
            emaillllabel = new Label();
            usernamelabel = new Label();
            passwordtextBox = new TextBox();
            nametextBox = new TextBox();
            passwordlabel = new Label();
            namelabel = new Label();
            Loginlabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(register);
            panel1.Controls.Add(loginbutton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(emaillllabel);
            panel1.Controls.Add(usernamelabel);
            panel1.Controls.Add(passwordtextBox);
            panel1.Controls.Add(nametextBox);
            panel1.Controls.Add(passwordlabel);
            panel1.Controls.Add(namelabel);
            panel1.Controls.Add(Loginlabel);
            panel1.Location = new Point(36, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 604);
            panel1.TabIndex = 0;
            // 
            // register
            // 
            register.BackColor = Color.Black;
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register.ForeColor = Color.White;
            register.Location = new Point(154, 494);
            register.Name = "register";
            register.Size = new Size(221, 51);
            register.TabIndex = 15;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.Black;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.ForeColor = Color.White;
            loginbutton.Location = new Point(154, 400);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(221, 55);
            loginbutton.TabIndex = 14;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(452, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 172);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // emaillllabel
            // 
            emaillllabel.AutoSize = true;
            emaillllabel.Location = new Point(495, 205);
            emaillllabel.Name = "emaillllabel";
            emaillllabel.Size = new Size(94, 25);
            emaillllabel.TabIndex = 12;
            emaillllabel.Text = "Your Email";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Location = new Point(495, 136);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(99, 25);
            usernamelabel.TabIndex = 11;
            usernamelabel.Text = "Your Name";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(154, 258);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(221, 31);
            passwordtextBox.TabIndex = 6;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(154, 168);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(221, 31);
            nametextBox.TabIndex = 4;
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Location = new Point(25, 264);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(87, 25);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "Password";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(39, 171);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(59, 25);
            namelabel.TabIndex = 1;
            namelabel.Text = "Name";
            // 
            // Loginlabel
            // 
            Loginlabel.AutoSize = true;
            Loginlabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginlabel.Location = new Point(267, 28);
            Loginlabel.Name = "Loginlabel";
            Loginlabel.Size = new Size(108, 45);
            Loginlabel.TabIndex = 0;
            Loginlabel.Text = "Login";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Name = "LoginControl";
            Size = new Size(748, 721);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label passwordlabel;
        private Label namelabel;
        private Label Loginlabel;
        private TextBox passwordtextBox;
        private TextBox nametextBox;
        private PictureBox pictureBox1;
        private Label emaillllabel;
        private Label usernamelabel;
        private Button register;
        private Button loginbutton;
    }
}
