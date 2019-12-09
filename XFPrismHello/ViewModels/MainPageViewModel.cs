using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XFPrismHello.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        IPageDialogService _pageDialog;
        IFooService _fooService;
        public DelegateCommand CloseCommand { get; }

        //public DelegateCommand NavigateToSecondPage => new DelegateCommand(async () => await NavigationService.NavigateAsync("SecondPage", useModalNavigation: true));
        public DelegateCommand NavigateToSecondPage { get; set; } 

        public DelegateCommand ShowDialog{ get; set; }

        public DelegateCommand ShowAlert { get; set; }

        public DelegateCommand ChangeColor { get; set; }

        private Color bgColor;
        public Color BgColor
        {
            get { return bgColor; }
            set { SetProperty(ref bgColor, value); }
        }

        private string hello;

        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }


        public MainPageViewModel(INavigationService navigationService, IDialogService dialogService, IPageDialogService pageDialogService, IFooService fooService)
            : base(navigationService)
        {
            _pageDialog = pageDialogService;
            _fooService = fooService;
            Title = "Main Page";
            BgColor = Color.Cornsilk;
            Hello = _fooService.SayHello();
            ShowDialog = new DelegateCommand(async () =>
            {
                dialogService.ShowDialog("DialogView", CloseDialogCallback);
            });

            ShowAlert = new DelegateCommand(ShowSimpleAlert);

            //modal: useModalNavigation: true
            NavigateToSecondPage = new DelegateCommand(async () => 
                await NavigationService.NavigateAsync("SecondPage"));

            ChangeColor = new DelegateCommand(() => BgColor = Color.Red);
        }

        void CloseDialogCallback(IDialogResult dialogResult)
        {

        }

        void ShowSimpleAlert()
        {
            _pageDialog.DisplayAlertAsync("Dialog", "Alert!", "OK");
        }

    }
}
