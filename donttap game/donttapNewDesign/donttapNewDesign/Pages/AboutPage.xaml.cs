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

namespace donttapNewDesign.Pages
{
    /// <summary>
    /// Interakční logika pro AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        private readonly MainWindow _mainwindow;
        public AboutPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }

        private void MainBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }
    }
}
