using mh.datasource;
using mh.viewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace mh.view
{
    public partial class WeaponsList : UserControl
    {
        public WeaponsList(string type)
        {
            InitializeComponent();
            DataContext = new WeaponsListVM(type);
        }
        public WeaponsList()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuNormal);
        }

        private void Back_Enter(object sender, MouseEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuHover);
        }
    }
}
