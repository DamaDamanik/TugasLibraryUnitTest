using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLibrary
{
    public class User
    {
        /// <summary>
        /// Method ini akan mencocokan username dan password yang diberikan
        /// dengan username dan password yang terdaftar dalam database.
        /// </summary>
        /// <param name="userName">Diisi dengan user name</param>
        /// <param name="password">Diisi dengan password</param>
        /// <returns>
        /// Apabila cocok, akan menghasilkan true, dan apabila tidak cocok akan menghasilkan false.
        /// </returns>
        public bool IsValidUser(string userName, string password)
        {
            if (userName == "admin" && password == "admin")
                return true;
            else
                return false;
        }
    }
}
