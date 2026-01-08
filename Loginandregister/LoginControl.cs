using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Loginandregister.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Loginandregister
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = nametextBox.Text.Trim();
            string password = passwordtextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("عمر Username و Password");
                return;
            }

            string passwordHash = HashPassword(password);

            using (var db = new UsersDbContext())
            {
                var user = db.Users.FirstOrDefault(u =>
                    u.Username == username &&
                    u.PasswordHash == passwordHash);

                if (user != null)
                {
                    MessageBox.Show("Login success ✅");

                    // 🟢 عرض المعلومات
                    namelabel.Text = "Username: " + user.Username;
                    emaillllabel.Text = "Email: " + user.Email;

                    if (!string.IsNullOrEmpty(user.Picture) && File.Exists(user.Picture))
                    {
                        pictureBox1.Image = Image.FromFile(user.Picture);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Username أو Password غلط ❌");
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {

        }
    }
}
