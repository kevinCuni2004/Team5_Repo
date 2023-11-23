using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    public class Access
    {
        private DBConnection dBConnection;
        public Access()
        {
            dBConnection = DBConnection.getInstance();
        }
       //--С каждым новым профилем должны добавляться ряды--//
    }
}
