﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    class Profile
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }

        private int _adminID;
        public int AdminID { get { return _adminID; } set { _adminID = value; } }

        private string _username;
        public string Username { get { return _username; } set { _username = value; } }

        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }

        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        private int _age;
        public int Age { get { return _age; } set { _age = value; } }

        private string _email;
        public string Email { get { return _email; } set { _email = value; } }

        private string _password;
        public string Password { get { return _password; } set { _password = value; } }

        private int _access;
        public int Access { get { return _access; } set { _access = value; } }

        private string _details;
        public string Details { get { return _details;} set { _details = value; } }
    }
}
