using System;
using TipCalculatorApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TipCalculatorApp
{
    public partial class App : Application
    {
        private static ViewModelLocator viewModelLocator;

        public static ViewModelLocator ViewModelLocator
        {
            get
            {
                if (viewModelLocator == null)
                    viewModelLocator = new ViewModelLocator();

                return viewModelLocator;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
