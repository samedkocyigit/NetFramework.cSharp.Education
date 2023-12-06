using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.FormWindows
{
    public class temporaryDB
    {
        public static List<User> userDB = new List<User>();
        public static List<User> usersDB= new List<User>();

        static temporaryDB()
        {
            userDB.Add(new User()
            {
                name= "nur",
                  password="123",
                   surname="koc",
                    userName="nurkoc",
                     commentBelow="Here is the information of the person who Nur Koc"
            });

            userDB.Add(new User()
            {
                name = "samed",
                  password = "123",
                   surname = "koc",
                    userName = "samedkoc",
                     commentBelow = "Here is the information of the person who Samed Koc"
            }) ;
        }
    }
}
