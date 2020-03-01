using System;
using System.Collections.ObjectModel;
using MediatR;
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

        public Command AddDiceValueCommand { get; set; }

        private void AddDiceValue()
        {
            Console.WriteLine("hit this");
        }
    }
}
