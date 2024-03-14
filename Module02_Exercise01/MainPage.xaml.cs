using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module02_Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Clicked_ViewDataBinding (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewDataBinding());
        }

        private async void  Clicked_CodeBehindBinding (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CodeBehindBinding());
        }

        private async void Clicked_NoBindingContext (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoBindingContext());
        }
    }
}
