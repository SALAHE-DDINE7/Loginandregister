namespace Loginandregister
{
    partial class LoginFrom
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            emaillabel = new Label();
            namelabel = new Label();
            chosepicbutton = new Button();
            label5 = new Label();
            Loginbutton = new Button();
            Registerbutton = new Button();
            emailtextBox = new TextBox();
            passwordtextBox = new TextBox();
            nametextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(emaillabel);
            panel1.Controls.Add(namelabel);
            panel1.Controls.Add(chosepicbutton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Loginbutton);
            panel1.Controls.Add(Registerbutton);
            panel1.Controls.Add(emailtextBox);
            panel1.Controls.Add(passwordtextBox);
            panel1.Controls.Add(nametextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 552);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(447, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 187);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(644, 188);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 13;
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Location = new Point(522, 188);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(94, 25);
            emaillabel.TabIndex = 12;
            emaillabel.Text = "Your Email";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(522, 126);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(99, 25);
            namelabel.TabIndex = 11;
            namelabel.Text = "Your Name";
            // 
            // chosepicbutton
            // 
            chosepicbutton.BackColor = Color.Black;
            chosepicbutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chosepicbutton.ForeColor = SystemColors.ButtonHighlight;
            chosepicbutton.Location = new Point(126, 249);
            chosepicbutton.Name = "chosepicbutton";
            chosepicbutton.Size = new Size(209, 45);
            chosepicbutton.TabIndex = 10;
            chosepicbutton.Text = "Chose ur profile";
            chosepicbutton.UseVisualStyleBackColor = false;
            chosepicbutton.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 259);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 9;
            label5.Text = "Picture";
            // 
            // Loginbutton
            // 
            Loginbutton.AccessibleRole = AccessibleRole.None;
            Loginbutton.BackColor = Color.Black;
            Loginbutton.FlatStyle = FlatStyle.Flat;
            Loginbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.ForeColor = Color.White;
            Loginbutton.Location = new Point(126, 445);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(209, 49);
            Loginbutton.TabIndex = 8;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            // 
            // Registerbutton
            // 
            Registerbutton.AccessibleRole = AccessibleRole.None;
            Registerbutton.BackColor = Color.Black;
            Registerbutton.FlatStyle = FlatStyle.Flat;
            Registerbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbutton.ForeColor = Color.White;
            Registerbutton.Location = new Point(126, 375);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(209, 49);
            Registerbutton.TabIndex = 7;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(126, 188);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(209, 31);
            emailtextBox.TabIndex = 6;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(126, 310);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(209, 31);
            passwordtextBox.TabIndex = 5;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(126, 126);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(209, 31);
            nametextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 313);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 188);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 132);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 30);
            label1.Name = "label1";
            label1.Size = new Size(151, 45);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoginFrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 698);
            Controls.Add(panel1);
            Name = "LoginFrom";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox emailtextBox;
        private TextBox passwordtextBox;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button Registerbutton;
        private Button Loginbutton;
        private Label label5;
        private TextBox nametextBox;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Label namelabel;
        private Button chosepicbutton;
        private PictureBox pictureBox1;
        private Label label8;
        private Label emaillabel;
    }
}
