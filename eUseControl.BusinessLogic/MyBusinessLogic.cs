using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top_Infinity.BusinessLogic.Interfaces;

namespace Top_Infinity.BusinessLogic
{
    public class MyBusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
