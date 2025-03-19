using mh.datasource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mh.view
{
    /// <summary>
    /// Lógica de interacción para Armors.xaml
    /// </summary>
    public partial class Armors : UserControl
    {
        public Armors()
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
