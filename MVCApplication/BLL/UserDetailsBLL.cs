using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVCApplication.DAL;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.BLL
{
    public class UserDetailsBLL
    {
        private IConfiguration _config;
        public UserDetailsBLL(IConfiguration config)
        {
            _config = config;
        }
        public List<User> GetUserDetailsByUserId(string userId)
        {
            return (new UserDetailsDAL(_config)).GetUserDetailsByUserId(userId);
        }

        public void ExportToExcel(ControllerBase controller, string userId)
        {
            new UserDetailsDAL(_config).ExportToExcel(controller, userId);
        }
    }
}
