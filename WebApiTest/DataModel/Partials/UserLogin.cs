using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public partial class UserLogin
    {
        private CTX db = new CTX();

        public IQueryable<UserLogin> GetUserLogins()
        {
            return db.UserLogins;
        }
    }
}
