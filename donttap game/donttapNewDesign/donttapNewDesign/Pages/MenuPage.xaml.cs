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
using System.IO;

namespace donttapNewDesign.Pages
{
    /// <summary>
    /// Interakční logika pro MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        private readonly MainWindow _mainwindow;
        public MenuPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(1);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //var txt = File.ReadAllLines("txt/random.txt");
            //Random rdm = new Random();
            //TextBlockRandomText.Text = txt[rdm.Next(0, txt.Length - 1)];
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            //edit or create settings.json

            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(2);
        }

        private void ButtonEndurance_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(3);
        }

        private void ButtonFrenzy_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(4);
        }

        private void ButtonPattern_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(5);
        }

        private void ButtonLeaderboard_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(7);
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }
        int clicked;
        private void Page_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (clicked == 14)
            {
                System.Diagnostics.Process.Start("cmd", "/C start https://www.instagram.com/p/Cd51zPoLJS7/");
                clicked = 0;
            }
            else
                clicked++;
        }
    }
}
