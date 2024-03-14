using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module02_Exercise01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDataBinding : ContentPage
    {
        public ViewDataBinding()
        {
            InitializeComponent();
        }
        private async void Clicked_MainPage (object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}