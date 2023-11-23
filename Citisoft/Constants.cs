using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    class Constants
    {
        //Profile Table query constants
        public static string SELECT_PROFILE = "SELECT * FROM Profile WHERE [e-mail]=@e-mail;";
        public static string ADD_PROFILE = "INSERT INTO Profile ([e-mail], [password]) VALUES (@e-mail,@password);";
        public static string ADD_PROFILE_DETAILS = "UPDATE Profile SET [admin_id]=@adminID,[username]=@username,[first_name]=@fname,[last_name]=@lname,[age]=@age,[access]=@access,[details]=@details WHERE [e-mail]=@email;";
        public static string DISPLAY_SOME_PROFILE_DATA = "INSERT INTO Profile ([profile_id], [access], [username]) VALUES (@profileID,@access,@username);";
        public static string EDIT_SOME_PROFILE_DATA = "UPDATE Profile SET [profile_id]=@profileID, [access]=@access, [username]=@username WHERE [profile_id]=@profileID;";
    }
}
