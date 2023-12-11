using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Citisoft
{
    public class Profile
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

        private DateTime _dateOfBirth;
        public DateTime DateofBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        private string _email;
        public string Email { get { return _email; } set { _email = value; } }

        private string _password;
        public string Password { get { return _password; } set { _password = value; } }

        private int _access;
        public int Access { get { return _access; } set { _access = value; } }

        private string _details;
        public string Details { get { return _details;} set { _details = value; } }

        public Profile() { }

        public Profile(string email, string password)
        {
            this._email = email;
            this._password = password;
        }

        public UserTab UserTab
        {
            get => default;
            set
            {
            }
        }

        public LogIn LogIn
        {
            get => default;
            set
            {
            }
        }

        public SignUp SignUp
        {
            get => default;
            set
            {
            }
        }
    }
}
