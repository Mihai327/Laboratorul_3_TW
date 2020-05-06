using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top_Infinity.BusinessLogic.Core;
using Top_Infinity.BusinessLogic.Interfaces;
using Top_Infinity.Domain.Entities.User;

namespace Top_Infinity.BusinessLogic
{
    class SessionBL: UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return new ULoginResp();
        }
    }
}
