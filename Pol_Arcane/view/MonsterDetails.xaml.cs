using mh.viewModel;
using System.Windows.Controls;

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
    }
}
