using So_Hoa_ITVN_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Hoa_ITVN_Services.Services.ServicesUser
{
    public interface IServicesUser
    {
        S_Users GetUser(int userId);
        List<S_Users> GetListUser();
        bool Delete(int userID);
        bool Insert(S_Users user);
        bool Update(S_Users user);
    }
}
