using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using TipCalculatorApp.Models;
using TipCalculatorApp.Repositories;
using TipCalculatorApp.Services;

namespace TipCalculatorApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ITipService tipService;

        public MainPageViewModel(ITipService tipService)
        {
            this.tipService = tipService;
        }

        //Initiate Props for Inputs
        private string inputRestaurant;
        public string InputRestaurant
        {
            get
            {
                return inputRestaurant;
            }
            set
            {
                inputRestaurant = value;
                RaisePropertyChanged(() => InputRestaurant);
            }
        }

        private decimal givenPrice;
        public decimal GivenPrice
        {
            get
            {
                return givenPrice;
            }
            set
            {
                givenPrice = value;
                RaisePropertyChanged(() => GivenPrice);
            }
        }

        private decimal givenTipPercent;
        public decimal GivenTipPercent
        {
            get
            {
                return givenTipPercent;
            }
            set
            {
                givenTipPercent = value;
                RaisePropertyChanged(() => GivenTipPercent);
            }
        }

        //Initiate Props for Labels
        private Tip calculatedTip;
        public Tip CalculatedTip
        {
            get
            {
                return calculatedTip;
            }
            set
            {
                calculatedTip = value;
                RaisePropertyChanged(() => CalculatedTip);
            }
        }

        //Initiate Props for List
        //List<Tip> update de listview niet. Veranderen naar ObservableCollection fixt dit
        //Vraag in les: Convert functie -> Moet dit in Services geplaatst worden?
        private ObservableCollection<Tip> savedTips;
        public ObservableCollection<Tip> SavedTips
        {
            get
            {
                return savedTips;
            }
            set
            {
                savedTips = value;
                RaisePropertyChanged(() => SavedTips);
            }
        }

        //Button Relays
        public RelayCommand CalculateTip
        {
            get
            {
                return new RelayCommand(DisplayTip);
            }
        }

        public RelayCommand SaveTip
        {
            get
            {
                return new RelayCommand(SaveAndDisplayTip);
            }
        }

        //Button Functions
        private void DisplayTip()
        {
            //Maakt Tip Object aan om te tonen
            Tip newTip = new Tip() { Restaurant = InputRestaurant, BillAmount = GivenPrice, TipPercent = GivenTipPercent };
            //Bind op GUI
            CalculatedTip = newTip;
        }

        private void SaveAndDisplayTip()
        {
            //Maakt Tip Object om op te slaan
            Tip newTip = new Tip() { Restaurant = InputRestaurant, BillAmount = GivenPrice, TipPercent = GivenTipPercent };
            //Add Nieuwe Tip in de lijst (in Repository) en Return de geupdate lijst
            List<Tip> listOfTips = tipService.SetTips(newTip);
            //Convert van List<Tip> Naar ObservableCollection<Tip> om te displayen in listview
            ObservableCollection<Tip> myCollection = new ObservableCollection<Tip>(listOfTips);
            //Bind Nieuwe List op pagina
            SavedTips = myCollection;
        }
    }
}
