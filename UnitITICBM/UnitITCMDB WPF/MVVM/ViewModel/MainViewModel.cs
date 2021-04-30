using System;
using System.Collections.Generic;
using System.Text;
using UnitITCMDB_WPF.Core;

namespace UnitITCMDB_WPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CustomerViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public CustomerViewModel CustomerVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CustomerVm = new CustomerViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            CustomerViewCommand = new RelayCommand(o =>
            {
                CurrentView = CustomerVm;
            });
        }
    }
}
