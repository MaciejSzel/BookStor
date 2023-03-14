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

namespace Projekcik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void ZamknijAplikacjeClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonZamknijMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOtwórzMenu.Visibility = Visibility.Visible;
            ButtonZamknijMenu.Visibility = Visibility.Collapsed;

        }

        private void ButtonOtwórzMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOtwórzMenu.Visibility = Visibility.Collapsed;
            ButtonZamknijMenu.Visibility = Visibility.Visible;
        }
    }
}
