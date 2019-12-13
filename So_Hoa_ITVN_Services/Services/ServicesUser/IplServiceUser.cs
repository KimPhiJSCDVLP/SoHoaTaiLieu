using So_Hoa_ITVN_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Hoa_ITVN_Services.Services.ServicesUser
{
    public class IplServiceUser : IServicesUser
    {
        private ApplicationDbContext db;

        public bool Delete(int userID)
        {
            if (userID !=0)
            {
                return true;
            }
            else
                return true;
        }

        public List<S_Users> GetListUser()
        {
            return db.S_Users.ToList();
        }

        public S_Users GetUser(int userID)
        {
            var user = db.S_Users.Find(userID);
            return user;
        }

        public bool Insert(S_Users user)
        {
            if (user != null)
            {
                return true;
            }
            else
                return true;
        }

        public bool Update(S_Users user)
        {
            if (user != null)
            {
                return true;
            }
            else
                return true;
        }
    }
}
