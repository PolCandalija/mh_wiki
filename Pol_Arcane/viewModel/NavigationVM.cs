using mh.utilites;
using mh.view;
using System.Windows.Input;

namespace mh.viewModel
{
    class NavigationVM : ViewModelBase
    {
        public string _monsterId = "10";

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnProperyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand MonsterCommand { get; set; }
        public ICommand WeaponCommand { get; set; }
        public ICommand ArmorCommand { get; set; }
        public ICommand SkillCommand { get; set; }
        public ICommand MapCommand { get; set; }
        public ICommand WeaponsListCommand { get; set; }
        public ICommand MonsterDetailsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Monster(object obj) => CurrentView = new MonstersVM();
        private void Weapon(object obj) => CurrentView = new WeaponsVM();
        private void Armor(object obj) => CurrentView = new ArmorsVM();
        private void Skill(object obj) => CurrentView = new SkillsVM();
        private void Map(object obj) => CurrentView = new MapsVM();

        private void WeaponsList(object obj)
        {
            if (obj is string type)
            {
                CurrentView = new WeaponsList(type);
            }
        }
        private void MonsterDetails(object obj)
        {
            if (obj is string name)
            {
                CurrentView = new MonsterDetails(name);
            }
        }

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            MonsterCommand = new RelayCommand(Monster);
            WeaponCommand = new RelayCommand(Weapon);
            ArmorCommand = new RelayCommand(Armor);
            SkillCommand = new RelayCommand(Skill);
            MapCommand = new RelayCommand(Map);
            WeaponsListCommand = new RelayCommand(WeaponsList);
            MonsterDetailsCommand = new RelayCommand(MonsterDetails);

            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
