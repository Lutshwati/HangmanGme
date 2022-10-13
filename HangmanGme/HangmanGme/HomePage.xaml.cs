using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HangmanGme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void _Easy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void _Medium_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Medium());
        }

        private void _Hard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hard());
        }
    }
}