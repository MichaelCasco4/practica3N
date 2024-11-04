using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.models.resourses
{
    internal class UserService
    {
       public bool ValidateUser(string username, string password)
        {
            return username == "admin" && password == "1234";
        }

    }
}
