using App2.BO;
using App2.MockData;
using App2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

          
            listeTweets.ItemsSource = TweetsMockData.ListeTweets();

            connectionFragment.ConnectionViewModel.listeTweets = listeTweets;
           

        }
    }
}
