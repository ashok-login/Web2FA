using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public int OparId { get; set; }
    }
}
