using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class UserInfo
    {
        public string UserEmail { get; set; }
        public string UserName { get; set; }

        public override string ToString()
        {
            return $"{UserName} and {UserEmail}";
        }
    }
}