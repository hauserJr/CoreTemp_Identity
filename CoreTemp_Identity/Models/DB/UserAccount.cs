using System;
using System.Collections.Generic;

namespace CoreTemp_Identity.Models
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Pwd { get; set; }
    }
}
