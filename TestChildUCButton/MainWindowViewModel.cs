using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace TestChildUCButton
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<PersonViewModel> _people = new ObservableCollection<PersonViewModel>();
        public ObservableCollection<PersonViewModel> People { get => _people; set { Set(() => People, ref _people, value); } }


        private RelayCommand<PersonViewModel> _messageNameCmd;
        public RelayCommand<PersonViewModel> MessageNameCmd => _messageNameCmd ?? (_messageNameCmd = new RelayCommand<PersonViewModel>(
            (pvm) => MessageBox.Show(pvm.Name,"Name"),
            (pvm) => { return 1 == 1; },
			keepTargetAlive:true
            ));

        private RelayCommand<PersonViewModel> _messageAgeCmd;
        public RelayCommand<PersonViewModel> MessageAgeCmd => _messageAgeCmd ?? (_messageAgeCmd = new RelayCommand<PersonViewModel>(
            (pvm) => MessageBox.Show(pvm.Age.ToString(),"Age"),
            (pvm) => { return 1 == 1; },
            keepTargetAlive: true
            ));


        public MainWindowViewModel()
        {
            loadSampleData();
        }


        private void loadSampleData()
        {
            People.Add(new PersonViewModel("Undici", 11));
            People.Add(new PersonViewModel("Dodici", 12));
        }
    }
}
