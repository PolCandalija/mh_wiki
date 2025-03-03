using mh.viewModel;
using System.Windows.Controls;

namespace mh.view
{
    public partial class WeaponsList : UserControl
    {
        public WeaponsList(string type)
        {
            InitializeComponent();
            DataContext = new WeaponsListVM(type);
        }
    }
}
