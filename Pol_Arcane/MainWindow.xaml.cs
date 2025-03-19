using mh.datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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

namespace mh
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //test
        public MainWindow()
        {
            DBDatasource.DBConnection.Open();
            InitializeComponent();
            MhSounds.PlayBackgroundMusic();
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            DBDatasource.DBConnection.Close();
            Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) {
                this.DragMove();
            }
        }

        private void Menu_Normal(object sender, RoutedEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuNormal);
        }

        private void md_menu_normal(object sender, MouseButtonEventArgs e)
        {
        }

        private void Menu_Hover(object sender, MouseEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuHover);
        }

        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Menu_Main(object sender, RoutedEventArgs e)
        {
            MhSounds.PlaySound(MhSounds.menuMain);
        }
        private void Close_App(object sender, RoutedEventArgs e)
        {
        }
    }
}
