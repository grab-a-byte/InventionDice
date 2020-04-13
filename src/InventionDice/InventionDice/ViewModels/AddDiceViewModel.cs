using InventionDice.AppFiles.AddDice;
using InventionDice.Infrastructure;
using InventionDice.Infrastructure.Extensions;
using InventionDice.Services.Navigation;
using MediatR;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace InventionDice.ViewModels
{
    public class AddDiceViewModel : ViewModelBase
    {
        private readonly IMediator mediator;
        private readonly INavigationService navigationService;
        private ObservableCollection<string> diceValues;

        public AddDiceViewModel(IMediator mediator, INavigationService navigationService)
        {
            this.mediator = mediator;
            this.navigationService = navigationService;
            AddDiceValueCommand = new Command(AddDiceValue);
            SaveDiceCommand = new Command(SaveDice);
            DiceValues = new ObservableCollection<string>();
        }

        public ObservableCollection<string> DiceValues
        {
            get => diceValues;
            set
            {
                diceValues = value;
                NotifyPropertyChanged();
            }
        }

        private string _diceName = "";
        public string DiceName
        {
            get => _diceName;
            set
            {
                _diceName = value;
                NotifyPropertyChanged();
            }
        }

        private string _inputValue = "";

        public string InputValue
        {
            get => _inputValue; 
            set
            {
                _inputValue = value;
                NotifyPropertyChanged();
            }
        }

        private bool _saving = false;
        public bool Saving
        {
            get => _saving;
            set
            {
                _saving = value;
                NotifyPropertyChanged();
            }
        }

        public Command AddDiceValueCommand { get; set; }

        public Command SaveDiceCommand { get; set; }

        private void AddDiceValue()
        {
            if (InputValue.IsNotEmpty() && !Saving)
            {
                DiceValues.Add(InputValue.Trim());
                InputValue = "";
            }
        }

        private async void SaveDice()
        {
            Saving = true;
            try
            {
                Result result = await mediator.Send(new AddDiceRequest(DiceName, DiceValues));
                if (result.Successful)
                    navigationService.NavigateAsRoot<MainViewModel>();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something ent wrong");
            }
        }
    }
}