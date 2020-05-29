using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestChildUCButton
{
    public class MainWViewModel :ViewModelBase
    {
        private MainWindowViewModel _mainWindowViewModel= new MainWindowViewModel(); 
        public MainWindowViewModel MainWindowViewModel { get => _mainWindowViewModel; set { Set(() => MainWindowViewModel, ref _mainWindowViewModel, value); } }

        public MainWViewModel()
        {

        }
    }
}
