using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    class UserTab
    {
        private Profile user;
        private DBConnection dBConnection;

        private void loadData()
        {
            user = new Profile();
            dBConnection = DBConnection.getInstance();
        }
    }
}
