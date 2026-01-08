using Loginandregister.Data;
using Loginandregister.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Loginandregister
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        // 
        // Hash Password
        //
        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                var sb = new System.Text.StringBuilder();
                foreach (var b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        //
        // Selectionner une image de profile
        //
        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Tag = ofd.FileName; // on garde le chemin pour la DB
                }
            }
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            string username = nametextBox.Text.Trim();
            string email = emailtextBox.Text.Trim();
            string password = passwordtextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            string passwordHash = HashPassword(password);
            string picturePath = pictureBox1.Tag?.ToString(); // peut être null

            using (var db = new UsersDbContext())
            {
                // Vérifier si l'email existe déjà
                if (db.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("Cet email est déjà utilisé !");
                    return;
                }

                var user = new Users
                {
                    Username = username,
                    Email = email,
                    PasswordHash = passwordHash,
                    Picture = picturePath
                };

                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("Compte créé avec succès !");
                // 🔹 Afficher le Username et Email dans les Labels
                namelabel.Text = "Username : " + user.Username;
                emaillabel.Text = "Email : " + user.Email;


                // 🔹 Vider les TextBox pour le prochain enregistrement
                nametextBox.Text = "";
                emailtextBox.Text = "";
                passwordtextBox.Text = "";

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            loginControl1.BringToFront();
        }
    }
}
