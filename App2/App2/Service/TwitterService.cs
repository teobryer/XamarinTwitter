using App2.BO;
using App2.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Service
{
    public class TwitterService : ITwitterService
    {
        private IAuthenticatorService AuthenticatorService  = new AuthenticatorService();
        public User authentificate(string username, string password)
        {
           return AuthenticatorService.connexion(username, password);
        }

        public List<Tweet> getListTweets()
        {
            throw new NotImplementedException();
        }
    }
}
