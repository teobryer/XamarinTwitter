using App2.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.MockData
{
    public class UserMockData
    {

        public static List<User> ListeUtilisateurs()
        {
            var users = new List<User>
            {
                new User { Username = "teo", Password = "teo" },
                new User { Username = "val", Password = "1234" },
                new User { Username = "max", Password = "jaipasdemotdepasse" },
                new User { Username = "coco", Password = "corentin422000" },
                new User { Username = "nico", Password = "tumefaischier" }
            };

            return users;

        }
    }
}
