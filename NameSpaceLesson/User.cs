using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceLesson
{
    internal class User
    {
        public string Name { get; }
        public string Surname { get; }
        public string Username { get; }
        public string Password { get; }

        public User(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }
    }
}
