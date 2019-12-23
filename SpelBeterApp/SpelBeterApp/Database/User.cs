using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpelBeterApp.Database
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(70)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }
    }
}
