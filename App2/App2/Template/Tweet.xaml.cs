using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Template
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tweet : ViewCell
    {
        public Tweet()
        {
            InitializeComponent();
        }
    }
}