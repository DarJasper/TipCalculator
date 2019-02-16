using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using TipCalculatorApp.Repositories;
using TipCalculatorApp.Services;

namespace TipCalculatorApp.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ITipRepository, TipRepository >();

            SimpleIoc.Default.Register<ITipService, TipService>();

            SimpleIoc.Default.Register<MainPageViewModel>();
        }

        public MainPageViewModel MainPageViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainPageViewModel>();
            }
        }
    }
}
