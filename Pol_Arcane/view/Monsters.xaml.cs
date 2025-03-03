using mh.viewModel;
using System.Windows.Controls;

namespace mh.view
{
    public partial class Monsters : UserControl
    {
        public Monsters()
        {
            InitializeComponent();

            DataContext = new MonstersVM();
        }
    }
}
