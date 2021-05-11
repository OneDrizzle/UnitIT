using System.Collections.Generic;
using UnitITICBM.Persistance;
using UnitItWPF.Core;

namespace UnitItWPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand CustomerViewCommand { get; set; }

        public RelayCommand ComponentViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public CustomerViewModel CustomerVm { get; set; }

        public ComponentViewModel ComponentVm { get; set;}

        private UnitITICBM.Models.Customer selectedItem;

        public UnitITICBM.Models.Customer SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
            }
        }

        public IEnumerable<UnitITICBM.Models.CI> list { get;set; }

        private object _currentView;


        public CIRepository cRepo = new CIRepository(new AttributeRepositoryDB(), new CustomerRepositoryDB(), new TypeRepositoryDB());

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
            ComponentVm = new ComponentViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            CustomerViewCommand = new RelayCommand(o =>
            {
                CurrentView = CustomerVm;
            });

            ComponentViewCommand = new RelayCommand(o =>
            {
                CurrentView = ComponentVm;
            });

            
        }

        public IEnumerable<UnitITICBM.Models.CI> Update_Datagrid()
        {
            if (selectedItem != null)
            {
                list = cRepo.GetAll(SelectedItem.CustomerID);
                return list;
            }
            else
            {
                return null;
            }
        }

    }
}
