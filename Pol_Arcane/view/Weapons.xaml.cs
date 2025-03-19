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
using mh;
using mh.datasource;

namespace mh.view
{
    /// <summary>
    /// Lógica de interacción para Weapons.xaml
    /// </summary>
    public partial class Weapons : UserControl
    {
        public Weapons()
        {
            InitializeComponent();
        }

        private void Weapon_Click(object sender, RoutedEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.armor);
        }

        private void Weapon_Enter(object sender, MouseEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuHover);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuNormal);
        }

        private void Back_Enter(object sender, MouseEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuHover);
        }
        private void Play_rare(object sender, RoutedEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.rare);
        }
    }
}
