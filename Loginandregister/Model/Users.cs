 using System;
using System.Collections.Generic;
using System.Text;

namespace Loginandregister.Model
{
    public class Users
    {
            public int Id { get; set; } // PK
            public string Username { get; set; }
            public string Email { get; set; }
            public string PasswordHash { get; set; }
            public string? Picture { get; set; } // chemin de l'image
        
    }
}
