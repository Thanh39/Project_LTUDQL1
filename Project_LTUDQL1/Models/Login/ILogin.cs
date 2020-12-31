using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LTUDQL1.Models.Login
{
    public interface ILogin
    {
        string Username { get; }
        string Password { get; }
        string Message { get; set; }
        string CheckConnectionMessage { set; }
        object User { get; set; }

        event EventHandler Login;
        event EventHandler CheckConnection;
    }
}
