using CarSharing.Core;
using System;

namespace CarSharing.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CarsViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public CarsViewModel CarsVM { get; set; }

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
            HomeVM = new HomeViewModel();
            CarsVM = new CarsViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            CarsViewCommand = new RelayCommand(o =>
            {
                CurrentView = CarsVM;
            });
        }

    }
}
