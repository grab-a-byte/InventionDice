using MediatR;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace InventionDice.ViewModels
{
    public class AddDiceViewModel : ViewModelBase
    {
        private readonly IMediator mediator;
        private ObservableCollection<string> diceValues;

        public AddDiceViewModel(IMediator mediator)
        {
            this.mediator = mediator;
            AddDiceValueCommand = new Command(AddDiceValue);
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

        private string _inputValue = "";

        public string InputValue
        {
            get => _inputValue; set
            {
                _inputValue = value;
                NotifyPropertyChanged();
            }
        }

        public Command AddDiceValueCommand { get; set; }

        private void AddDiceValue()
        {
            DiceValues.Add(InputValue);
            InputValue = "";
        }
    }
}