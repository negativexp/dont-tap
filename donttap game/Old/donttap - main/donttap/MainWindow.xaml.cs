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

namespace donttap
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeContent()
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.WindowState = WindowState.Maximized;
            //this.WindowStyle = WindowStyle.None;
        }

        private void ButtonEndurence_Click(object sender, RoutedEventArgs e)
        {
            FramePage.Content = new Viewmodels.Endurence.Settings.Settings(this);
            GridAll.Visibility = Visibility.Hidden;
        }
    }
}
