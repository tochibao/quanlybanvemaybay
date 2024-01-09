using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVeMayBay
{
    internal class UserSession
    {
        private string Username;

        private static UserSession userSession;
        public UserSession(String username) {
            this.Username = username;
        }

        public String getUserName()
        {
            return this.Username;
        }

        public static UserSession GetUserSession(String username) {
            if (userSession == null)
            {
                userSession = new UserSession(username);
            }
            return userSession;
        }
    }
}
