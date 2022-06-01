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
            Classes.CreateData.Create(); 
        }

        static Pages.MenuPage menuPage;
        static Pages.SettingsPage settingsPage;
        static Pages.AboutPage aboutPage;
        static Pages.Endurence.EndurenceMainPage endurenceMainPage;
        static Pages.Endurence.EndurenceLeaderboardPage endurenceLeaderboardPage;
        static Pages.Frenzy.FrenzyMainPage frenzyMainPage;
        static Pages.Frenzy.FrenzyLeaderboardPage frenzyLeaderboardPage;


        private void LoadPages()
        {
            menuPage = new Pages.MenuPage(this);
            settingsPage = new Pages.SettingsPage(this);
            aboutPage = new Pages.AboutPage(this);
            endurenceMainPage = new Pages.Endurence.EndurenceMainPage(this);
            endurenceLeaderboardPage = new Pages.Endurence.EndurenceLeaderboardPage(this);
            frenzyMainPage = new Pages.Frenzy.FrenzyMainPage(this);
            frenzyLeaderboardPage = new Pages.Frenzy.FrenzyLeaderboardPage(this);
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
                this.Content = new Pages.Frenzy.FrenzyGame(this);
            if (x == 6)
                this.Content = new Pages.Endurence.EndurenceGame(this);
            if (x == 7)
                this.Content = endurenceLeaderboardPage;
            if (x == 8)
                this.Content = frenzyLeaderboardPage;
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
                    //189 189 199
                    this.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    this.WindowState = WindowState.Maximized;
                    isFullscreen = true;
                }
                else
                {
                    this.Background = new SolidColorBrush(Colors.Transparent);
                    this.WindowState = WindowState.Normal;
                    isFullscreen = false;
                }
            }
        }
    }
}
