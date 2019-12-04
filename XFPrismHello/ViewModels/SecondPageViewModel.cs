using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFPrismHello.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public DelegateCommand NavigateBack { get; set; }
        public SecondPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            NavigateBack = new DelegateCommand(async () =>
                await NavigationService.GoBackAsync());
        }
    }
}
