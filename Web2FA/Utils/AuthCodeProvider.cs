using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2FA.Utils
{
    public class AuthCodeProvider
    {
        public string Generate()
        {
            return Convert.ToString((new Random()).Next(100000, 999999));
        }
    }
}
