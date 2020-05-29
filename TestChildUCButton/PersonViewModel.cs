using GalaSoft.MvvmLight;

namespace TestChildUCButton
{
    public class PersonViewModel : ViewModelBase
    {
        private string _name = "name";
        public string Name { get => _name; set { Set(() => Name, ref _name, value); } }

        private int _age = 1;
        public int Age { get => _age; set { Set(() => Age, ref _age, value); } }

        public PersonViewModel()
        {

        }

        public PersonViewModel(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
