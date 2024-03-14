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
    public partial class NoBindingContext : ContentPage
    {
        public NoBindingContext()
        {
            InitializeComponent();
        }

        private async void Clicked_MainPage (object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void OnSliderValueChanged (object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            ratingLabel.Text = $"Rating: {value:F1}";
        }
    }
}