using mh.datasource;
using mh.viewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace mh.view
{
    public partial class Monsters : UserControl
    {
        public Monsters()
        {
            InitializeComponent();

            DataContext = new MonstersVM();
        }

        private void Monster_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.weapon);

        }

        private void Monster_Enter(object sender, System.Windows.Input.MouseEventArgs e)
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
    }
}
