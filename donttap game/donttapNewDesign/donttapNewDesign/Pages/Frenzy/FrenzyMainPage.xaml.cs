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

namespace donttapNewDesign.Pages.Frenzy
{
    /// <summary>
    /// Interakční logika pro FrenzyMainPage.xaml
    /// </summary>
    public partial class FrenzyMainPage : Page
    {
        private readonly MainWindow _mainwindow;
        public FrenzyMainPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            int[] settings = Classes.LoadSettings.Load();
            //int lastscore = Classes.LoadLastScore.Load(1);
            TextBlockBoardSize.Text = "Board size: " + settings[0];
            TextBlockBoxSize.Text = "Box size: " + settings[1];
            TextBlockSpacing.Text = "Spacing: " + settings[2];
            //TextBlockLastScore.Text = "Last score: " + lastscore;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLeaderBoard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }
    }
}
