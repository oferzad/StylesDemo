using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StylesDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void vcNoStyle_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoStyle());
        }

        private async void vcElement_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ElementLevelStyle());
        }

        private async void vcPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageLevelExplicityStyle());
        }

        private async void vcAppLevel_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppLevelStyles());
        }

        private async void vcDynamic_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicStyle());
        }

        private async void vcImplicit_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageLevelImplicitStyle());
        }

        private async void vcCSS_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CSSDemo());
        }
    }
}
