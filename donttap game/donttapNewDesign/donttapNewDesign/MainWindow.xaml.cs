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


        private void LoadPages()
        {
            menuPage = new Pages.MenuPage(this);
            settingsPage = new Pages.SettingsPage(this);
        }

        public void ChangeContent(int x)
        {
            if (x == 0)
                this.Content = menuPage;
            if (x == 1)
                this.Content = settingsPage;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPages();
            this.Content = menuPage;
        }
    }
}
