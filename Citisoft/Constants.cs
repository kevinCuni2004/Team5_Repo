using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    class Constants
    {
        public static string SELECT_PROFILE = "SELECT * FROM Profile WHERE [e-mail]=@e-mail;";
        public static string ADD_PROFILE = "INSERT INTO Profile ([e-mail], [password]) VALUES (@e-mail,@password);";
        public static string ADD_PROFILE_DETAILS = "UPDATE Profile SET [admin_id]=@adminID,[username]=@username,[first_name]=@fname,[last_name]=@lname,[age]=@age,[access]=@access,[details]=@details WHERE [e-mail]=@email;";

    }
}
