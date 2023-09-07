using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;

namespace SampleWebApp.Models
{
    public class UserInfo
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Otp { get; set; }

        public DateTime ExpiryDate { get; set; } = DateTime.Now.AddMinutes(5);
    }

}