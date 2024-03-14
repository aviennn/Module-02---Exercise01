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
    public partial class CodeBehindBinding : ContentPage
    {
        public CodeBehindBinding()
        {
            InitializeComponent();
            var aboutme = new aboutme
            {
                year = 3,
                hobby = "Playing games and watching movies",
                favgame = "Mobile Legends and Roblox",
                favkdrama = "Our beloved summer and Welcome to Samdal-dari"


            };

            BindingContext = aboutme;
        }

        private async void Clicked_MainPage (object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void MyName (object sender, EventArgs e)
        {
            displayName.Text = "My Name is Avien Flaire C. Batul";
            displayName.TextColor = Color.Purple;
        }

        void OnSliderValueChanged (object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingLabel.Rotation = value;
            displayRotation.Text = String.Format("The Slider value is {0}", value);
        }

  
    }
}