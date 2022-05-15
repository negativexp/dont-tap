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

namespace donttap.Viewmodels.GameOver
{
    /// <summary>
    /// Interakční logika pro GameOver.xaml
    /// </summary>
    public partial class GameOver : Page
    {
        private readonly MainWindow _mainWindow;
        public GameOver(MainWindow mainWindow, int points)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            TextBlockPoints.Text = "Points: " + points.ToString();
        }

        private void ButtonContinue_Click(object sender, RoutedEventArgs e)
        {
           

            _mainWindow.FramePage.Content = new Viewmodels.Endurence.Settings.Settings(_mainWindow);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _mainWindow.IsEnabled = true;
        }
    }
}
