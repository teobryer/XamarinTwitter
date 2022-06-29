using App2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Fragment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Connection : ContentView
    {
        public ConnectionViewModel ConnectionViewModel { get; set; }

        public Connection()
        {

            InitializeComponent();
            ConnectionViewModel = new ConnectionViewModel();
            BindingContext = ConnectionViewModel;
            ConnectionViewModel.connectionFragment = this;
        }

        private void Connection_Clicked(object sender, EventArgs e)
        {
            ConnectionViewModel.Clicked_Connection();
        }
    }
}