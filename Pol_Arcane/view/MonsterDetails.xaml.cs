using mh.datasource;
using mh.viewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace mh.view
{
    public partial class MonsterDetails : UserControl
    {
        public MonsterDetails(string name)
        {
            InitializeComponent();
            DataContext = new MonsterDetailsVM(name);
        }
        public MonsterDetails()
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
