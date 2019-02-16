using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Hier wordt alles aangemaakt
            BindingContext = App.ViewModelLocator.MainPageViewModel;
        }
    }
}
