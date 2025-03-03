using mh.viewModel;
using System.Windows.Controls;

namespace mh.view
{
    public partial class Skills : UserControl
    {
        public Skills()
        {
            InitializeComponent();

            DataContext = new SkillsVM();
        }
    }
}
