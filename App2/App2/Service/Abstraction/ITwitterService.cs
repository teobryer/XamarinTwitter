using App2.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Service.Abstraction
{
    public interface ITwitterService
    {
        User authentificate(string username, string password);
        List<Tweet> getListTweets();

    }
}
