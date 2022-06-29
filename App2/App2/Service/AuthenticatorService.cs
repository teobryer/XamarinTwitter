using App2.BO;
using App2.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App2.Service
{
    public class AuthenticatorService : IAuthenticatorService
    {
        public User connexion(string username, string password)
        {
            List<User> tousLesUtilisateurs = MockData.UserMockData.ListeUtilisateurs();

            var userConnect = tousLesUtilisateurs.FirstOrDefault(user => user.Username == username && user.Password == password);

            return userConnect;
        }
    }
}
