using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_login
{
    internal class LoginProgram
    {
        private bool is_authenticated;
        ConnectToDatabase connect;
        public LoginProgram()
        {
            
            is_authenticated = false;
            // ez a változó tárolja a bejelentkezést
            connect = new ConnectToDatabase();
        }

        private string GetInput()
        {
            throw new NotImplementedException();
            /* 
             ide jön a input bekérése. célszerű egy ciklust létrehozni,
            amiből csak úgy van szökés ha a bevitt input nem egyenő ""-vel (üres string)
             */
        }
        public void Login()
        {
            throw new NotImplementedException();
            /* 
             itt kérjük be a felhasznlónevet és a jelszót.
            felhasznév = getinpu()

              ha connect.finduser()
             
             */
        }


    }
}
