using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2.ViewModel
{
    public class ConnectionViewModel
    {
        public ListView listeTweets { get; set; }


        public string Username { get; set; }
        public string Password { get; set; }

        public void Clicked_Connection()
        {
            Console.WriteLine("username:" + Username + "; password:" + Password);
            listeTweets.IsVisible = true;
        }
    }
}
