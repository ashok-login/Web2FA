using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class UserModel
    {
        public UserOptions UserOptions { get; set; }
        public List<User> UserDetails { get; set; }
    }
}
