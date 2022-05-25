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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace donttapNewDesign
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

        static Pages.MenuPage menuPage;
        static Pages.SettingsPage settingsPage;
        static Pages.AboutPage aboutPage;
        static Pages.Endurence.EndurenceMainPage endurenceMainPage;
        static Pages.Frenzy.FrenzyMainPage frenzyMainPage;
        static Pages.Pattern.PatternMainPage patternMainPage;
        static Pages.LeaderboardPage leaderboardMainPage;


        private void LoadPages()
        {
            menuPage = new Pages.MenuPage(this);
            settingsPage = new Pages.SettingsPage(this);
            aboutPage = new Pages.AboutPage(this);
            endurenceMainPage = new Pages.Endurence.EndurenceMainPage(this);
            frenzyMainPage = new Pages.Frenzy.FrenzyMainPage(this);
            patternMainPage = new Pages.Pattern.PatternMainPage(this);
            leaderboardMainPage = new Pages.LeaderboardPage(this);
        }

        public void ChangeContent(int x)
        {
            if (x == 0)
                this.Content = menuPage;
            if (x == 1)
                this.Content = settingsPage;
            if (x == 2)
                this.Content = aboutPage;
            if (x == 3)
                this.Content = endurenceMainPage;
            if (x == 4)
                this.Content = frenzyMainPage;
            if (x == 5)
                this.Content = patternMainPage;
            if (x == 6)
                this.Content = new Pages.Endurence.EndurenceGame(this);
            if (x == 7)
                this.Content = leaderboardMainPage;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPages();
            this.Content = menuPage;
        }
        bool isFullscreen = false;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F)
            {
                if(!isFullscreen)
                {
                    this.Background = new SolidColorBrush(Color.FromRgb(209, 213, 222));
                    this.WindowState = WindowState.Maximized;
                    ChangeSizeFullscreen();
                    isFullscreen = true;
                }
                else
                {
                    this.Background = new SolidColorBrush(Colors.Transparent);
                    this.WindowState = WindowState.Normal;
                    ChangeSizeNormal();
                    isFullscreen = false;
                }
            }
        }
        private void ChangeSizeFullscreen()
        {
            double width = System.Windows.SystemParameters.WorkArea.Width;
            double height = System.Windows.SystemParameters.WorkArea.Height;

            menuPage.Width = width;
            menuPage.Height = height;
            settingsPage.Width = width;
            settingsPage.Height = height;
            aboutPage.Width = width;
            aboutPage.Height = height;
            endurenceMainPage.Width = width;
            endurenceMainPage.Height = height;
            frenzyMainPage.Width = width;
            frenzyMainPage.Height = height;
            patternMainPage.Width = width;
            patternMainPage.Height = height;
        }
        private void ChangeSizeNormal()
        {
            double width = 450;
            double height = 700;

            menuPage.Width = width;
            menuPage.Height = height;
            settingsPage.Width = width;
            settingsPage.Height = height;
            aboutPage.Width = width;
            aboutPage.Height = height;
            endurenceMainPage.Width = width;
            endurenceMainPage.Height = height;
            frenzyMainPage.Width = width;
            frenzyMainPage.Height = height;
            patternMainPage.Width = width;
            patternMainPage.Height = height;
        }
    }
}
