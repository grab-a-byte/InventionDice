using System;
using System.Collections.Generic;
using System.Text;
using InventionDice.ViewModels;

namespace InventionDice.Services.Navigation
{
    public class ViewModelFactory
    {
        private readonly Func<Type, object> serviceLocator;

        public ViewModelFactory(Func<Type, object> serviceLocator)
        {
            this.serviceLocator = serviceLocator;
        }

        public TViewModel GetViewModel<TViewModel>() where TViewModel : ViewModelBase
        {
            return (TViewModel)serviceLocator(typeof(TViewModel));
        }
    }

}
