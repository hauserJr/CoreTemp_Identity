using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTemp_Identity.Models.SYSTEM
{
    public static class SysBase
    {
        private static string cookie = "goodarc";

        public static string cookieName
        {
            get { return cookie; }
            set { value = cookie; }
        }
    }
}
