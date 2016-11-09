using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessEntities
{
    public class BLUserLogin
    {
        UserLogin userLogin = new UserLogin();
        
        public IQueryable<UserLogin> GetUserLogins()
        {
            return userLogin.GetUserLogins();
        }
    }
}
