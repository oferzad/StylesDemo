using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicStyle : ContentPage
    {
        public DynamicStyle()
        {
            InitializeComponent();
            Resources["myStyle"] = Resources["firstStyle"];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Resources["myStyle"] == Resources["firstStyle"])
                Resources["myStyle"] = Resources["secondStyle"];
            else
                Resources["myStyle"] = Resources["firstStyle"];
        }
    }
}