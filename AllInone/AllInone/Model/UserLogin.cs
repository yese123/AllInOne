using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInone.Model
{
    public class UserLogin : User
    {
        private string checkCode { get; set; }
        private string rememberPwd { get; set; }
        private string loginSubmit { get; set; }
    }
}
