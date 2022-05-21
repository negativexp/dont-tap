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


        private void LoadPages()
        {
            menuPage = new Pages.MenuPage(this);
            settingsPage = new Pages.SettingsPage(this);
            aboutPage = new Pages.AboutPage(this);
            endurenceMainPage = new Pages.Endurence.EndurenceMainPage(this);
            frenzyMainPage = new Pages.Frenzy.FrenzyMainPage(this);
            patternMainPage = new Pages.Pattern.PatternMainPage(this);
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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPages();
            this.Content = menuPage;
        }
    }
}
