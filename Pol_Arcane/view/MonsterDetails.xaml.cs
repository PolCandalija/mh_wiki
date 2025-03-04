using mh.viewModel;
using System.Windows.Controls;

namespace mh.view
{
    public partial class MonsterDetails : UserControl
    {
        public MonsterDetails(int id)
        {
            InitializeComponent();
            DataContext = new MonsterDetailsVM(id);
        }
        public MonsterDetails()
        {
            InitializeComponent();
        }
    }
}
