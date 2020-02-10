using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2FA.Utils
{
    public class UserRepository
    {
        List<User> users;
        public UserRepository()
        {
            users = new List<User>();
            users.Add(new User { UserId = 1, Email = "ashok_kottagundu@epam.com", MobileNumber = "9989540862" });
            users.Add(new User { UserId = 2, Email = "Kiran_Vaddi@epam.com", MobileNumber = "9494384743" });
        }

        public string GetCurrentUserMobileNumber()
        {
            var email = "Kiran_Vaddi@epam.com";
            return users.Find(x => x.Email == email).MobileNumber;
        }
    }
}
