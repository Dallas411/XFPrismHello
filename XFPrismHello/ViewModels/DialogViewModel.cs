﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFPrismHello.ViewModels
{
    public class DialogViewModel : IDialogAware
    {

        public DelegateCommand CloseCommand { get; }
        public DialogViewModel()
        {
            CloseCommand = new DelegateCommand(() => RequestClose(null));
        }


        public event Action<IDialogParameters> RequestClose;



        public bool CanCloseDialog() => true;



        public void OnDialogClosed()

        {



        }



        public void OnDialogOpened(IDialogParameters parameters)

        {



        }
    }
}
