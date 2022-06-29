using App2.Fragment;
using App2.Service;
using App2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App2.ViewModel
{
    public class ConnectionViewModel : INotifyPropertyChanged
    {
        public ListView listeTweets { get; set; }
        public Connection connectionFragment { get; set; }

        private readonly TwitterService twitterService = new TwitterService();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private Field<string> username = new Field<string> { Value = "test", IsValid = false, ErrorMessage = "zebi" };

        public Field<string> Username
        {
            set
            {
                username = value;
                OnPropertyChanged("Username");

            }
            get { return username; }
        }



        public Field<string> Password { get; set; } = new Field<string> { Value = "", IsValid = false, ErrorMessage = "zebi" };

        public void Clicked_Connection()
        {
            Console.WriteLine("username:" + Username + "; password:" + Password);


            if (twitterService.authentificate(Username.Value, Password.Value) != null)
            {
                listeTweets.IsVisible = true;
                connectionFragment.IsVisible = false;
                Username.IsValid = true;


            }

            else
            {
                Username.IsValid = false;
                Username.ErrorMessage = "Test erreur";
            }
        }
    }
}
